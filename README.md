## Intro

3hr coding test

I've made a .NET Core Web Api and a Vue.js frontend to take the JSON, convert it into 
the appropriate domain object and send it over https to be made pretty by vuejs.

## Run Application
Run ./RUNME.sh

cd GameApi
dotnet run &
cd ../gameview
npm run serve

## Run Test
cd GameApiTest
dotnet test
cd gameview
npm test

## Future work
Figure out why mocha doesn't run tests
Add e2e tests
