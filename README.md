# Gummi Bear Kingdom

This is a project created for the Epicodus code challenge for weeks 1 and 2 of .NET. It is an application for the employees of Gummi Bear Kingdom to be able to keep track of their gummi bear products. The application has full CRUD capabilities for products and the ability create reviews and see an average product rating.

## Prerequisites

Prior to cloning, please ensure that you have VisualStudio 2017 and MAMP installed on your machine.


### Installing

Navigate to the project repository on Github: https://github.com/rpgandhi/DOTNETGummiBear.git

Select the green Clone button and copy the link

Open Terminal or your shell of choice

Navigate to your desktop and run the following command:
```
$ git clone
```
Navigate into the project directory and run the following commands:
```
$ dotnet restore
```
Ensure that MAMP is open and your server is running on port 8889 then run the following command in your terminal:
```
$ dotnet ef database update
```

You should now have a copy fully installed on your machine

Then in order to launch the project in your browser, run the following command which will launch the server then in your browser navigate to localhost:5000
```
$ dotnet run
```
Alternatively, you may open up the project in Visual Studio and press the "play" button

When you are ready to shut down your server press CTL + C, close your browser, and click the "Stop Servers" button on your MAMP window


## Built With

* .NET Core
* C#
* HTML/CSS
* MAMP

## Authors

* **Rakhee Gandhi**

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
