# MarbleBucketTest
Test assignment for Developer position at MarbleBucket.

## 1. Configuration

1. Create a copy of this repository in your local computer.
2. Open the project using Visual Studio
3. Build the project (to generate .exe files)

## 2. How to run

### As command line executable:

1. Using your command line, go to the folder where your generated .exe file are located ("bin/debug" or "bin/release") depending on your configuration.
2. Run the following command: "MarbleBucketAveragingAPI --console" (IMPORTANT --console at the end). That will run the executable and start the server.

### As Windows Service:

1. Open your command line as an administrator. 
2. Go to 'C:\Windows\Microsoft.NET\Framework\v4.0.30319'
3. Run the tool 'installutil' and pass as an argument the full path of your .exe file ("C:\..\bin\debug\MarbleBucketAveragingAPI.exe" or "C:\..bin\release\..") depending on your configuration.
4. Use your web service


## 3. Testing

### Using Postman

In order to prove that this API works, I've used a software called "Postman" which can be downloaded from the internet. You can also use Fiddler, or any other tool of your preference.

1. Open Postman
2. Create a POST request to the specified URL: http://localhost:9000/api/average
3. Include the following key/value in your request Headers: "Content-Type": "application/json"
4. Include an array of numbers in the body of your request (as raw data)
5. Send.
6. You should receive a response with status 200 (Ok) and your averaged result (also displayed in the console).

## 4. Assumptions

- The host is using a Windows computer (necessary to run as a service)
- The host has .NET 4.5 installed
- The user will only send valid arrays of numbers (Validation is not the focus of this test, I believe)