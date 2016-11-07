Scenarios:-

Scenario 01: Successful calculation of tax refund for single purchase.
Given user is on 'Refund Calulator' page
When user selects Purchase country 'Austria' from the dop down
And enter amount '250' in purchase amount
And click on calulate button
Then Tax refund is calculated according to the country percentage.
----------------------------------------------------------------------------------------------------

Scenario 02: Enable Calculate button 
Given user is on 'Refund Calulator' page
When user selects Purchase country 'Austria' from the dop down
Then 'Calculate' button will be enabled
----------------------------------------------------------------------------------------------------------

Pre-Condition Purchase amount minimum limit for Austria is 75.01 Euros to get refund money
Scenario 03: Shows error message when the purchase amount is less than the specified limit for tax refund.
Given user is on 'Refund Calulator' page
When user selects Purchase country 'Austria' from the dop down
And enter amount '50' euros in purchase amount
And click on calulate button
Then error mesage 'You will need to spend at least EUR75.01 to qualify for a tax refund.' will be displayed.
--------------------------------------------------------------------------------------------------------------

Scenario 04: Empty Purchase Amount
Given user is on 'Refund Calulator' page
When user selects Purchase country 'Austria' from the dop down
And click on calulate button
Then error message 'Your input is not a valid number. Please try again.'
-------------------------------------------------------------------------------------------------------------------

Scenario 05: Calculate multiple purchases for same country.
Given user is on 'Refund Calulator' page
When user selects Purchase country 'Austria' from the dop down
And enter amount '250' in purchase amount
And click on calulate button to display the calculate tax refund amount
And user clicks on append refund to add to total refund amount
And again user adds new purchase amount 
And clicks on calculate button to display the calculate refund amount
And user clicks on the append refund to add to total refund amount
Then the total refund will be sum of both purchases
--------------------------------------------------------------------------------------------------------------------





Missing requoirement that i will discuss with the Product owner.

1. Minimum and Maximum single Purchase limit.(per country)
2. Minimum and Maximum Multiple purchase limit.
3. Provide percentages for tax per country so to check if its calculating the amount correctly
4. Improvement for error message when purchase amount is empty 'your input is not a valid number. Please try again.' instead 'your purchase amount is not a valid number. Please try again.'
5. Suggestion In purchase amount currently no restriction for decimal digits should be limited.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


Bugs
1. When i put in amount somethings like 10000000000000000 it doesnt show an error message.
2. when i put something like 10000000000 the aligment of tax refund is bad
3. when i select a country calculate button is enable when i again go to the option select purchase country it should disable calculate button but the calculate button is still enable (should be discussed with the product owner if its ok or not)
4. Seems like for austria tax percentage is 12% but it is not calculating correctly(for example if 100 euro than 12euro, if 200 hundred than 23 euro, if 300 than 34, if 400 than 46 euros) so its calculating on diffrenet percentages on different amounts.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
