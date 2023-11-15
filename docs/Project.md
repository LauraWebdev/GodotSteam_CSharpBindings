# GodotSteam C# Bindings

[Back to README](../README.md)

## Table of Contents
- [Project Structure](#project-structure)
- [Contributing](#contributing)

## Project Structure
This project builds as one static "Steam" class with all methods and signals exposed with the same naming as in GDScript (but in PascalCase).

Methods are split in multiple partial classes of the "Steam" class for better readability. The split resembles the split of the GodotSteam documentation material. Signals are always placed under a .Signals.cs partial class of the same main partial class.

Initially, this project used the auto-generated C# gluecode Godot provides for the GDExtension for all method constants, signal constants and the mapping of methods and signals. Thus, updates of GodotSteam can be easily compared with an earlier version by running the Godot CLI with the `--generate-mono-glue` parameter.

**Keep in mind that the auto-generated C# gluecode cannot be used to call GodotSteam for various reasons and are only reference material for constants, names and parameters.**

## Contributing

1. **Fork** the project: Use the fork button in the top-right of the GitHub project page to create a copy of the repository in your own account.
2. **Clone** the repository: Use the command `git clone https://github.com/yourusername/repositoryname.git` to clone the forked repository on your local machine.
3. **Make sure GodotSteam runs**: Make sure GodotSteam is installed and running properly.
4. **Make your changes**: Once the project is set up, you can start making changes. Always create a new branch for your changes with `git checkout -b your-branch-name`.
5. **Create a pull request**: After pushing your changes to your forked repository, you can use the `Pull Request` button in GitHub to create a new pull request. Fill in the required information, explaining what changes you made.

Remember to keep your forked repository up to date with the main project if it's a long-term contribution. 