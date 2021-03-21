Feature: Banking
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](BankTestGherkin/Features/Banking.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

*Transfer money between accounts (not customers)
*Bank staff only charged 50% fee
*Base fee for failed transaction = $10
*Interest rate = 4%
*Add:
	Create new accounts
	Deposit and withdraw funds
	Transfer funds between accounts
	Calculate, Add interest
	Write, read customer, account data to and from serialised binary file

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120