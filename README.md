# AutoRestDateTimeOffsetBug

The problem is with converting DateTimeOffset to string, without specified formatting in auto generated method. As stated in 
https://msdn.microsoft.com/en-us/library/bb360056(v=vs.110).aspx#Anchor_2 ToString() method uses formatting information 
derived from the current culture. 

Formatting date as sortable (for example), solves the problem.
