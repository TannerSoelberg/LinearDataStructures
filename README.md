# LinearDataStructures

Please note: An additional ZIP file containing the program has been included in this repository.

# Self-Study Short Answers
Linked lists are notoriously good when quick insertion and removal into lists is necessary. Linked lists are able to dynamically expand and contract when you declare every new value. 
When the amount of elements that need to be gathered is unknown, linked lists offer a better alternative to massive arrays in terms of predictability and sometimes memory. An example of linked lists in action would be a program that needs to store the addresses on a street. If the amount of addresses was unknown, you could dynamically iterate through the addresses, and store them according to their house number.

Stacks and queues are different in nature. While queues follow the FIFO pattern (the first item put in is the first pulled out), stacks follow a LIFO pattern (the last item in is the first pulled out). Because of this behavior, stacks are best for maintaining the history of added items (you are able to recursively track back), while queues are best for the opposite (sequential ordering and retrieval).

A developer would use a stack while making a "undo" feature. This stack would track version or change history; after adding something to the stack, it would get the latest change (then revert it and remove the data from the undo stack).

A developer would use an array when they have a set number of homogenous items they need to track and access frequently. This allows for less memory consumption (better for low-end devices). For example, a developer could use an array of 50 strings to store the names of states in the US, on a mobile application.
