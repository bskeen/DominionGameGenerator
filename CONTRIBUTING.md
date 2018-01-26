# Contributing to the DominionGameGenerator

Thank you for being willing to contribute to this project! Having more people contribute can drastically improve the quality and usability of the website.

# Filing a Bug Report

Please file all bug reports on [GitHub](https://github.com/bskeen/DominionGameGenerator/issues). When creating an issue, please try to include the following:

- A detailed description of the problem you are experiencing.
- Steps to recreate the bug, including what your inputs were.

# Setting up your Development Environment

The backend for this project was written in .Net Core using the latest release of Visual Studio 2017. The frontend code can be found in the subfolder located at `DominionGameGenerator.Web\app`, and was written in Visual Studio Code. Angular 4 is the framework used, and it was generated using the Angular CLI.

Once you open the solution in Visual Studio, you will need to restore the packages for the project. You can do this by running the `Update-Package -reinstall` command in the Package Manager Console. You also should make sure that the `DominionGameGenerator.Web` project is selected as the startup project before running the server.

To set up the front end, navigate to the directory at `DominionGameGenerator.Web\app` in a terminal window, and run `npm install`. The project is configured to output built files in the folder at `DominionGameGenerator.Web\wwwroot`, so if you run `ng build` and then go back to Visual Studio, you should be able to run the server, and you can access the website running at `http://localhost:21294/`.

# Submitting Pull Requests

Please submit all pull requests to the development branch. Production builds will then be merged into the master branch.

# Future Tasks for the Project

Some important tasks that still need to be completed for the project:

- Add testing. So far, no unit tests have been written.
- Update the SASS files to implement a better design, so the web site looks better and has a better user experience.
- Clean up how the cards are listed. Currently, if there is a card that is included because it is required by a supply card, then it is listed under every card that requires it. Should think about making a new section, that lists all additional cards required by the supply cards.

Some possible tasks that could be implemented in the future:

- Add authentication to the project. You would be able to share a game with the other players, so everyone can see what cards are needed and help to set up.
- Add a database to contain the cards and user info.
- Store in the database cards used for a game, so you can give preference to cards you haven't used yet (you could include who you are playing with, so the group you are playing with hasn't seen the cards yet).
- Add more controls that help you set up a game (for example, choose at least 2 attack cards to be used in the game, or choose other types of cards or cards that complement each other).

# Contact Information

Please voice any questions, comments or concerns you have on Gitter:

[![Join the chat at https://gitter.im/DominionGameGenerator/Lobby](https://badges.gitter.im/DominionGameGenerator/Lobby.svg)](https://gitter.im/DominionGameGenerator/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
