## Dependency Injection Demo

This repository contains a simple C\# console application that serves as a practical demonstration of the **Dependency Injection** (DI) design pattern. It's built to help developers, particularly those new to the concept, understand how to decouple components and manage dependencies effectively in a .NET environment.

-----

### Getting Started

To run this project, you will need the following prerequisites installed on your machine:

  * .NET SDK (version compatible with a .NET Framework or .NET Core console application)
  * Visual Studio or Visual Studio Code

**Instructions:**

1.  Clone the repository to your local machine:
    ```bash
    git clone https://github.com/omkarshinde1711/Dependency_Injection_demo.git
    ```
2.  Open the solution file (`Dependency_Injection_demo.sln`) in Visual Studio.
3.  Restore the NuGet packages by right-clicking the solution in the Solution Explorer and selecting **Restore NuGet Packages**.
4.  Build the solution (Build \> Build Solution).
5.  Run the application by pressing `F5` or by clicking the Start button.

-----

### 💡 Features

This demo illustrates key aspects of Dependency Injection, including:

  * **Inversion of Control (IoC):** The program demonstrates how the control of creating and managing object dependencies is inverted from the consuming class to a container or framework.
  * **Interface-based Programming:** It shows the use of interfaces to define contracts, allowing different concrete implementations to be swapped without modifying the dependent class.
  * **Constructor Injection:** This is the primary method of DI showcased in the demo, where dependencies are provided to a class through its constructor.

-----

### Repository Structure

The project has a clear and simple structure:

  * `Models/`: Contains the classes that represent the application's data or logic.
  * `Program.cs`: The entry point of the application, where the DI setup and main logic are executed.
  * `*.csproj`: The C\# project file.
  * `*.sln`: The solution file for Visual Studio.
  * `App.config`: The application configuration file.

-----

### License

This project is licensed under the **MIT License**. For more details, see the `LICENSE.txt` file.

-----

### Contributing

Contributions are welcome\! If you have suggestions for improvements or want to add more examples of DI, feel free to open a pull request.
