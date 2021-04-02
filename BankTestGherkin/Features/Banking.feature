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
Scenario Outline: Transfer acc types
  Given account <name> is selected
  When I transfer <amount> to <type>
  Then <type> is transferred to

  Examples:
    | name      | amount | type      |
    | Omni      | 400    | Lifestyle |
    | Lifestyle | 100    | Everyday  |
    | Everyday  | 10     | Omni      |
    | Omni      | 400    | Omni      |
    | Lifestyle | 100    | Lifestyle |
    | Everyday  | 10     | Everyday  |

@mytag
Scenario Outline: Transfer balances
  Given account <name> is selected
  When I transfer <amount> to <type>
  Then <type> is transferred to

  Examples:
    | name      | amount | type      |
    | Omni      | 400    | Lifestyle |
    | Lifestyle | 100    | Everyday  |
    | Everyday  | 10     | Omni      |
    | Omni      | 0    | Everyday  |
    | Lifestyle | 0    | Omni      |
    | Everyday  | 0   | Lifestyle |

@mytag
Scenario Outline: Transfer overdrafts
  Given customer is not <staff>
  When <amount> transferred is more than <balance>
  Then the account is charged a <fee>
  And the <fee> should be withdrawn from the <balance>

  Examples:
    | staff | amount | balance | fee |
    | false  | 100    | 0       | 5   |
    | false  | 3      | 4       | 5   |
    | false | 5      | 5       | 10  |
    | false | 44     | 901     | 5   |

@mytag
Scenario Outline: Transfer staff fees
  Given customer is <staff>
  When <amount> transferred is more than <balance>
  Then the account is charged a <fee>
  And the <fee> should be withdrawn from the <balance>

  Examples:
    | staff | amount | balance | fee |
    | true  | 100    | 0       | 5   |
    | true  | 3      | 4       | 5   |
    | true | 5      | 5       | 10  |
    | true  | 44     | 901     | 5   |

