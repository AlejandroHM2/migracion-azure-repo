FROM liquibase/liquibase
COPY changelog/. /liquibase/changelog/.
COPY user.yaml .
ENTRYPOINT ["liquibase", "--defaultsFile=/liquibase/changelog/liquibase.properties", "--changelog-file=user.yaml","--log-level=info", "update" ]