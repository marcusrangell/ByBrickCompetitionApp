# ByBrickCompetitionApp

## Description
Project used in a competition by ByBrick during christmas/new years 2022. The original sourcecode were to be optimized as seen fit.


## Enhancement ideas / thought of process
TBD


## Commits and performance gains
The average run time after specific commits as follows:
* **2e32711** Initial commit - **174s**
* **542d951** Move StreamWriter declaration out from loop. - **1.6s**
* **5056cbf** Remove StreamWriter Flush() - **281ms**
* **ac7e302** Set buffersize on StreamWriter to 64k - **260ms**
