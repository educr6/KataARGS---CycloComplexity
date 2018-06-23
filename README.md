# KataARGS---CycloComplexity
Created to ilustrate a decrease in cyclometric complexity of a prepared kata code

Kata source: https://codingdojo.org/kata/Args/



| Name of method      | Previous Complexity   | New Complexity  |
| ------------------: |:---------------------:| :-------------: |
| Main()              |           8           |       2         |
| hasPortMethod       |           .           |       4         |
| hasDirectoryMethod  |           .           |       5         |


Tets methods with CC of one cannot be lowered

| Name of TestMethods                                         | Previous Complexity     | New Complexity   | 
| ------------------------------------------------------------: |:---------------------:| :-------------:  |
| CaseWithoutArgsLoginReturnsFalse()                          |           1             |       1          |
| CaseWithLoginReturnsTrue()                                  |           1             |       1          |
| CaseWithoutAnyArgumentsReturns                              |           1             |       1          |
| CaseWithPortReturnsTrue()                                   |           1             |       1          |
| CaseWithLoginAndPortReturnBothTrue()                        |           1             |       1          |
| CaseWithLoginAndPortReturnsLoginTruePortFalse()             |           1             |       1          |
| CaseWithDirectoryReturnsTrue()                              |           1             |       1          |
| CaseWithDirectoryArgsWithoutDirectionsReturnsFalse          |           1             |       1          |
| CaseWithoutLoginWithDirectoryArgAndPortBothReturn true      |           1             |       1          |
