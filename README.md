# Plan for testing of ErrorReport-API.

# Introduction:
This is a plan/instruction for the testing of our ErrorReport-API.
You will test getting a list of reports, Creating a report and deleting a report.
Test strategy:
This plan is focused on testing of functionality.

# Testcases:
1: Creating two reports through Swagger.

2: Getting the list of reports in Swagger.

3: Deleting a report in Swagger. (Input an id of your choice from the list you get from testcase 2)

4: Running our xUnit tests and reporting on the results.

# Test environment:
You need to download our repository from GitHub to Visual Studio and make sure you have a local database (update-database in Package Manager Console). Make sure you alter the connectionstring in appsettings.json if you want to specify the name of the database.

# Risks and dependencies:
There is a risk of removing production data if we run the tests against the production database. 
There is a risk that our xUnit test for getting a list of all reports will not pass because we have hardcoded the expected elementcount in our assertion. This risk can be averted by replacing the expected number with the value of the number of reports you have in your local database.

# Criterias for Approval/disapproval of the testcycle:
If 50% of the testcases are successful we consider this cycle a huge win!

# Report of test results and evaluation:
Report if all tests were successful. If not include information on which testcases failed and any conclussions as to why it failed. 
