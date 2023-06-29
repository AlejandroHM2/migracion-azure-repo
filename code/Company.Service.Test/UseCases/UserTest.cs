// <summary>
// <copyright file="UserTest.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Test.UseCases;

/// <summary>
/// User Test Class.
/// </summary>
[TestFixture]
public class UserTest : BaseTest
{
    private IMapper mapper;
    private IDataBaseContext context;
    private IUnitOfWork unitOfWork;
    private IUserRepository users;
    private IUserDetailRepository userDetails;
    private IDistributedCache cache;

    /// <summary>
    /// Method to init values.
    /// </summary>
    [OneTimeSetUp]
    public void Init()
    {
        var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<UserProfile>());
        this.mapper = mapperConfiguration.CreateMapper();

        var options = Options.Create<EndpointSettings>(
            new EndpointSettings()
            {
                ConnectionString = "Data Source=MyDatabase.sqlite;Version=3;",
            });

        this.context = new UserContext(options, true);
        CreateTables(this.context);
        this.users = new UserRepository(this.context);
        this.userDetails = new UserDetailRepository(this.context);
        this.unitOfWork = new UnitOfWork(this.users, this.userDetails);
        this.cache = new Mock<IDistributedCache>().Object;
    }

    /// <summary>
    /// Test for Create User.
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestCreateUserAsync()
    {
        CreateUserDto user = new CreateUserDto()
        {
            CreationDate = DateTime.Now,
            Email = "a@a.com",
            Id = 5,
            LastName = "Test LN",
            Name = "Test N",
            UserType = "Admin",
            UserDetails = new List<UserDetailDto>()
            {
                new UserDetailDto()
                {
                    Id = 5,
                    Description = "Test",
                    UserId = 5,
                },
            },
        };

        CreateUserInputPort createUserInputPort = new CreateUserInputPort(user, new Mock<IOutputPort<long>>().Object);
        CreateUserInteractor createUserInteractor = new CreateUserInteractor(this.unitOfWork, this.mapper);
        await createUserInteractor.Handle(createUserInputPort, CancellationToken.None);

        var response = await this.users.GetById(5);
        Assert.IsNotNull(response);
        Assert.AreEqual(5, response.Id);
        Assert.AreEqual("a@a.com", response.Email);
        Assert.AreEqual("Test LN", response.LastName);
        Assert.AreEqual(UserType.Admin, response.UserType);
        Assert.AreEqual("Test N", response.Name);
    }

    /// <summary>
    /// Test for Delete User.
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestDeleteUserAsync()
    {
        DeleteUserInputPort deleteUserInputPort = new DeleteUserInputPort(1, new Mock<IOutputPort<long>>().Object);
        DeleteUserInteractor deleteUserInteractor = new DeleteUserInteractor(this.unitOfWork);
        await deleteUserInteractor.Handle(deleteUserInputPort, CancellationToken.None);

        var response = await this.users.GetById(1);
        Assert.IsNull(response);
    }

    /// <summary>
    /// Test for Get User By Id.
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestGetUserByIdAsync()
    {
        GetUserByIdInputPort getUserByIdInputPort = new GetUserByIdInputPort(5, new Mock<IOutputPort<UserDto>>().Object);
        GetUserByIdInteractor getUserByIdInteractor = new GetUserByIdInteractor(this.unitOfWork, this.mapper, this.cache);
        await getUserByIdInteractor.Handle(getUserByIdInputPort, CancellationToken.None);

        var response = await this.users.GetById(5);
        Assert.IsNotNull(response);
        Assert.AreEqual(5, response.Id);
        Assert.AreEqual("a@a.com", response.Email);
        Assert.AreEqual("Test LN", response.LastName);
        Assert.AreEqual(UserType.Admin, response.UserType);
        Assert.AreEqual("Test N", response.Name);
    }

    /// <summary>
    /// Test for Get All User.
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestGetAllUsersAsync()
    {
        GetAllUserInputPort getAllUserInputPort = new GetAllUserInputPort(new Mock<IOutputPort<IEnumerable<UserDto>>>().Object);
        GetAllUserInteractor getAllUserInteractor = new GetAllUserInteractor(this.unitOfWork, this.mapper, this.cache);
        await getAllUserInteractor.Handle(getAllUserInputPort, CancellationToken.None);
        var response = await this.users.GetAll();
        Assert.IsNotNull(response);
        Assert.AreEqual(4, response.Count());
    }

    /// <summary>
    /// Test for Update User.
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestUpdateUserAsync()
    {
        UpdateUserDto user = new UpdateUserDto()
        {
            CreationDate = DateTime.Now,
            Email = "a@b.com",
            Id = 2,
            LastName = "Test LN",
            Name = "Test N",
            UserType = "Admin",
            UserDetails = new List<UserDetailDto>()
            {
                new UserDetailDto()
                {
                    Id = 2,
                    Description = "Test 2",
                    UserId = 2,
                },
            },
        };

        UpdateUserInputPort updateUserInputPort = new UpdateUserInputPort(user, new Mock<IOutputPort<bool>>().Object);
        UpdateUserInteractor updateUserInteractor = new UpdateUserInteractor(this.unitOfWork, this.mapper);
        await updateUserInteractor.Handle(updateUserInputPort, CancellationToken.None);

        var response = await this.users.GetById(2);
        Assert.IsNotNull(response);
        Assert.AreEqual(2, response.Id);
        Assert.AreEqual("a@b.com", response.Email);
        Assert.AreEqual("Test LN", response.LastName);
        Assert.AreEqual(UserType.Admin, response.UserType);
        Assert.AreEqual("Test N", response.Name);
    }
}
