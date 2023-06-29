// <summary>
// <copyright file="[%= name %]Test.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Test.UseCases;

/// <summary>
/// [%= name %] Test Class.
/// </summary>
[TestFixture]
public class [%= name %]Test : BaseTest
{
    private IMapper mapper;
    private IDataBaseContext context;
    private IUnitOfWork unitOfWork;
    private I[%= name %]Repository [%= name_lower %]s;
    private I[%= name %]DetailRepository [%= name_lower %]Details;
    private IDistributedCache cache;

    /// <summary>
    /// Method to init values.
    /// </summary>
    [OneTimeSetUp]
    public void Init()
    {
        var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<[%= name %]Profile>());
        this.mapper = mapperConfiguration.CreateMapper();

        var options = Options.Create<EndpointSettings>(
            new EndpointSettings()
            {
                ConnectionString = "Data Source=MyDatabase.sqlite;Version=3;",
            });

        this.context = new [%= name %]Context(options, true);
        CreateTables(this.context);
        this.[%= name_lower %]s = new [%= name %]Repository(this.context);
        this.[%= name_lower %]Details = new [%= name %]DetailRepository(this.context);
        this.unitOfWork = new UnitOfWork(this.[%= name_lower %]s, this.[%= name_lower %]Details);
        this.cache = new Mock<IDistributedCache>().Object;
    }

    /// <summary>
    /// Test for Create [%= name %].
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestCreate[%= name %]Async()
    {
        Create[%= name %]Dto [%= name_lower %] = new Create[%= name %]Dto()
        {
            CreationDate = DateTime.Now,
            Email = "a@a.com",
            Id = 5,
            LastName = "Test LN",
            Name = "Test N",
            [%= name %]Type = "Admin",
            [%= name %]Details = new List<[%= name %]DetailDto>()
            {
                new [%= name %]DetailDto()
                {
                    Id = 5,
                    Description = "Test",
                    [%= name %]Id = 5,
                },
            },
        };

        Create[%= name %]InputPort create[%= name %]InputPort = new Create[%= name %]InputPort([%= name_lower %], new Mock<IOutputPort<long>>().Object);
        Create[%= name %]Interactor create[%= name %]Interactor = new Create[%= name %]Interactor(this.unitOfWork, this.mapper);
        await create[%= name %]Interactor.Handle(create[%= name %]InputPort, CancellationToken.None);

        var response = await this.[%= name_lower %]s.GetById(5);
        Assert.IsNotNull(response);
        Assert.AreEqual(5, response.Id);
        Assert.AreEqual("a@a.com", response.Email);
        Assert.AreEqual("Test LN", response.LastName);
        Assert.AreEqual([%= name %]Type.Admin, response.[%= name %]Type);
        Assert.AreEqual("Test N", response.Name);
    }

    /// <summary>
    /// Test for Delete [%= name %].
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestDelete[%= name %]Async()
    {
        Delete[%= name %]InputPort delete[%= name %]InputPort = new Delete[%= name %]InputPort(1, new Mock<IOutputPort<long>>().Object);
        Delete[%= name %]Interactor delete[%= name %]Interactor = new Delete[%= name %]Interactor(this.unitOfWork);
        await delete[%= name %]Interactor.Handle(delete[%= name %]InputPort, CancellationToken.None);

        var response = await this.[%= name_lower %]s.GetById(1);
        Assert.IsNull(response);
    }

    /// <summary>
    /// Test for Get [%= name %] By Id.
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestGet[%= name %]ByIdAsync()
    {
        Get[%= name %]ByIdInputPort get[%= name %]ByIdInputPort = new Get[%= name %]ByIdInputPort(5, new Mock<IOutputPort<[%= name %]Dto>>().Object);
        Get[%= name %]ByIdInteractor get[%= name %]ByIdInteractor = new Get[%= name %]ByIdInteractor(this.unitOfWork, this.mapper, this.cache);
        await get[%= name %]ByIdInteractor.Handle(get[%= name %]ByIdInputPort, CancellationToken.None);

        var response = await this.[%= name_lower %]s.GetById(5);
        Assert.IsNotNull(response);
        Assert.AreEqual(5, response.Id);
        Assert.AreEqual("a@a.com", response.Email);
        Assert.AreEqual("Test LN", response.LastName);
        Assert.AreEqual([%= name %]Type.Admin, response.[%= name %]Type);
        Assert.AreEqual("Test N", response.Name);
    }

    /// <summary>
    /// Test for Get All [%= name %].
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestGetAll[%= name %]sAsync()
    {
        GetAll[%= name %]InputPort getAll[%= name %]InputPort = new GetAll[%= name %]InputPort(new Mock<IOutputPort<IEnumerable<[%= name %]Dto>>>().Object);
        GetAll[%= name %]Interactor getAll[%= name %]Interactor = new GetAll[%= name %]Interactor(this.unitOfWork, this.mapper, this.cache);
        await getAll[%= name %]Interactor.Handle(getAll[%= name %]InputPort, CancellationToken.None);
        var response = await this.[%= name_lower %]s.GetAll();
        Assert.IsNotNull(response);
        Assert.AreEqual(4, response.Count());
    }

    /// <summary>
    /// Test for Update [%= name %].
    /// </summary>
    /// <returns>Task Test.</returns>
    [Test]
    public async Task TestUpdate[%= name %]Async()
    {
        Update[%= name %]Dto [%= name_lower %] = new Update[%= name %]Dto()
        {
            CreationDate = DateTime.Now,
            Email = "a@b.com",
            Id = 2,
            LastName = "Test LN",
            Name = "Test N",
            [%= name %]Type = "Admin",
            [%= name %]Details = new List<[%= name %]DetailDto>()
            {
                new [%= name %]DetailDto()
                {
                    Id = 2,
                    Description = "Test 2",
                    [%= name %]Id = 2,
                },
            },
        };

        Update[%= name %]InputPort update[%= name %]InputPort = new Update[%= name %]InputPort([%= name_lower %], new Mock<IOutputPort<bool>>().Object);
        Update[%= name %]Interactor update[%= name %]Interactor = new Update[%= name %]Interactor(this.unitOfWork, this.mapper);
        await update[%= name %]Interactor.Handle(update[%= name %]InputPort, CancellationToken.None);

        var response = await this.[%= name_lower %]s.GetById(2);
        Assert.IsNotNull(response);
        Assert.AreEqual(2, response.Id);
        Assert.AreEqual("a@b.com", response.Email);
        Assert.AreEqual("Test LN", response.LastName);
        Assert.AreEqual([%= name %]Type.Admin, response.[%= name %]Type);
        Assert.AreEqual("Test N", response.Name);
    }
}
