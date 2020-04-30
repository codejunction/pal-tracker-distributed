
# Push Command
cf push pal-tracker --random-route -p src/PalTracker/bin/Release/netcoreapp2.2/publish -b https://github.com/cloudfoundry/dotnet-core-buildpack/releases/download/v2.3.2/dotnet-core-buildpack-cflinuxfs3-v2.3.2.zip

# Assignment Submit
./gradlew cloudNativeDeveloperSimpleApp -PserverUrl=https://pal-tracker-zany-kob.cfapps.io

# Git Creds set
git config --global user.email "Abhishek_Dutta3@Dell.com"
git config --global user.name "Abhishek Dutta"


# Command Line config
dotnet run --project src/PalTracker WELCOME_MESSAGE="hello from the environment"
http://pal-tracker-reflective-turtle.cfapps.io/
./gradlew cloudNativeDeveloperCloudFoundry -PserverUrl=https://pal-tracker-reflective-turtle.cfapps.io/

# Command Pipeline
./gradlew cloudNativeDeveloperPipelines -PreviewUrl=https://msg-pal-tracker-abhishek-review.cfapps.io/ -PproductionUrl=https://msg-pal-tracker-abhishek-prod.cfapps.io/

# Command InMemeory DataStore
./gradlew cloudNativeDeveloperRest -PserverUrl=https://msg-pal-tracker-abhishek-prod.cfapps.io
https://msg-pal-tracker-abhishek-review.cfapps.io/time-entries

# Command SQL DataStore
cd ~/workspace/assignment-submission
./gradlew cloudNativeDeveloperDatabaseMigrations -PserverUrl=https://msg-pal-tracker-abhishek-prod.cfapps.io

# Command SQL DataStore Integration
cd ~/workspace/assignment-submission
./gradlew cloudNativeDeveloperDatabaseAccess -PserverUrl=https://msg-pal-tracker-abhishek-prod.cfapps.io

# Command Healthcheck
cf set-env pal-tracker-review MANAGEMENT__ENDPOINTS__CLOUDFOUNDRY__ENABLED false
cf restart pal-tracker-review

cd ~/workspace/assignment-submission
./gradlew cloudNativeDeveloperHealthMonitoring -PserverUrl=https://msg-pal-tracker-abhishek-review.cfapps.io/actuator

### PAL Distributed Systems

# Command 
### Registration Server
    > dotnet run --urls "http://*:8883" --project Applications/RegistrationServer
### Allocation Server
    > dotnet run --urls "http://*:8881" --project Applications/AllocationsServer
### Backlog Server
    > dotnet run --urls "http://*:8882" --project Applications/BacklogServer
### Timesheets
    > dotnet run --urls "http://*:8884" --project Applications/TimesheetsServer

## Command Assignment Sub
cd ~/workspace/assignment-submission
./gradlew dotnetCloudNativeDeveloperDistributedSystemDeployment -PregistrationServerUrl=https://registration-pal-abhishek.cfapps.io -PbacklogServerUrl=https://backlog-pal-abhishek.cfapps.io -PallocationsServerUrl=https://allocations-pal-abhishek.cfapps.io -PtimesheetsServerUrl=https://timesheets-pal-abhishek.cfapps.io

### PAL Service Registry Discovery

## Command Assignment Sub
cd ~/workspace/assignment-submission
./gradlew dotnetCloudNativeDeveloperDistributedSystemWithServiceDiscovery -PregistrationServerUrl=https://registration-pal-abhishek.cfapps.io -PbacklogServerUrl=https://backlog-pal-abhishek.cfapps.io -PallocationsServerUrl=https://allocations-pal-abhishek.cfapps.io -PtimesheetsServerUrl=https://timesheets-pal-abhishek.cfapps.io

### PAL Circuit Breaker

## Command Assignment Sub
cd ~/workspace/assignment-submission
./gradlew dotnetCloudNativeDeveloperDistributedSystemWithCircuitBreaker -PregistrationServerUrl=https://registration-pal-abhishek.cfapps.io -PbacklogServerUrl=https://backlog-pal-abhishek.cfapps.io -PallocationsServerUrl=https://allocations-pal-abhishek.cfapps.io -PtimesheetsServerUrl=https://timesheets-pal-abhishek.cfapps.io
