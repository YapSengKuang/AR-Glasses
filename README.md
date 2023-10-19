# AR-Glasses
FIT3170 Full Year project for AR Shopping List glasses

## Versioning Strategy
- Initial (Current) version: v1.0 
- As a proof of concept which has no plans to be deployed currently and is intended primarily for internal testing and experimentation, a simple sequential versioning strategy would be the best choice.
- We increment the version number each time we make updates to the POC. Therefore, the next version of the POC after the initial version will be v1.1.
- If there is a significant update or change with the POC, then it can be incremented by the whole number. For example, a significant new feature added to the current prototype will change the versioning to v2.0.

## Software required
- Unity: Development platform for creating the AR Application. 
- Android Studio: Integrated development environment (IDE) for Android app development and testing.
- XReal (Nreal) SDK : Software development kit for creating applications for the XReal (Nreal) AR Glasses.
- Unity: TextMeshPro package for components containing textmeshpro text box.

## Hardware required
- Android Device : Can be used for testing 
- XReal (Nreal) AR Development Glasses : Primary hardware to run our AR Shopping List, application is only able to run on the development kit. 
- Windows/Mac Computer: A computer capable of running Unity. 

## How the Application Runs
### Getting the shopping list on the glasses
**Step 1 - Creating the Shopping List**

The application accesses a .csv file to manage your shopping list.
You can make this using excel and creating a 3 columns labelled "No.", "Item", "Quantity" like this:

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147008473641537536/image.png)

alternatively you can use a text editor and use commas "," to separate the columns

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147008557716348998/image.png)

Ensure that the file is called MyShoppingList.csv

**Step 2 - Putting the Shopping List on the Glasses**

First turn on the computing unit and connect it to your computer via a cable.
Then copy your shopping list over to the "LukAR" folder in internal storage.
When you're done it should look like this:

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147021578916343900/image.png)
![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147021632053969016/image.png)

Afterwards you can disconnect your computing unit from your computer.

### How to use LukAR
When you open the application you will see "My Shopping List" to your left.

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023132067102840/image.png)

You can click it with the pointer to expand up your shopping list.

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023034398543973/image.png)

Once open you can minimise it by clicking the "X"
Note: if you do not see your list then check that your .csv file has been correctly placed.

This shopping list will update whenever you confirm an item. But you can manually change this by pressing the checkbox to the right.

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023283938672740/image.png)

When an item is checked, it will automatically be moved to the bottom of the shopping list and will not be detected again.

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023360077856820/image.png)

LukAR will automatically detect items on your shopping list and will point out a single instance of that item to you.

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023835007307907/image.png)

To collect that item, pick it up and move it close to the glasses, upon doing so you will see a confirmation popup.

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147024012459909140/image.png)

Use the pointer to click "yes" to mark it off the list or "no" if LukAR identified something wrong.

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147024133402673242/image.png)

## Pull Request Strategy

If you're interested in contributing, please follow our Pull Request Strategy outlined below.

### Pre-Requisites:

1. **Fork the Repository**: Before you can create a pull request, you must first fork our repository. This will create a personal copy of the codebase for you to work on.

2. **Clone Your Forked Repository**: Clone the forked repo to your local machine:
   ```bash
   git clone https://github.com/YourUsername/project-name.git
    ```
3. **Set Upstream**: Add our repository as an upstream to fetch changes from the main codebase:
    ```bash
    git remote add upstream https://github.com/OriginalRepoOwner/project-name.git
    ```
### Steps to Submit a Pull Request:
1. **Stay Updated**: Before you start working, make sure you have the latest changes from our main branch:
    ```bash
    git pull upstream main
    ```
2. **Create a New Branch**: Always create a new branch for every feature or bugfix:
    ```bash
    git checkout -b feature/your-feature-name OR bugfix/your-bugfix-name
    ```
3. **Work on Your Change**: Make your changes, ensuring you follow our coding standards and guidelines.
4. **Commit Your Changes**: Group related changes into logical commits and write a clear and meaningful commit message.
    ```bash
    git commit -m "Short description of changes made"
    ```
5. **Push to Your Fork**: Push your changes to your forked repo on GitHub:
    ```bash
    git push origin your-branch-name
    ```
6. **Create a Pull Request**: Go to your forked repo on GitHub and click on 'New Pull Request'. Select your branch from the dropdown and submit.

7. **Fill in Pull Request Details**: Provide a descriptive title and fill in the Pull Request template, detailing your changes and any other relevant information.

8. **Review and Address Feedback**: Once your Pull Request is submitted, maintainers or other contributors might provide feedback. Address any comments or suggestions as needed.
9. **Approval of Merge**: Once everything is set and the Pull Request is approved, it will be merged into our main branch.


## Additional Notes
- The scene for our application is in Assets > Scenes > Object Detection > LukarYoloObjectDetection > LukarYoloObjectDetection.unity. Press play to run it on Unity. 
- To use the pointer on Unity to test the application - which emulates the pointer from the computing unit of the glasses - you must continuously hold down the shift key and then move your cursor.
- For any scroll functions while game is active in unity, hold shift and drag mouse to use the scroll bar.
  
  
