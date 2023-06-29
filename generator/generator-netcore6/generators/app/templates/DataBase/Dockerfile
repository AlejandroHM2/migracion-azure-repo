FROM liquibase/liquibase
COPY changelog/. /liquibase/changelog/.
COPY [%= name_lower %].yaml .
ENTRYPOINT ["liquibase", "--defaultsFile=/liquibase/changelog/liquibase.properties", "--changelog-file=[%= name_lower %].yaml","--log-level=info", "update" ]