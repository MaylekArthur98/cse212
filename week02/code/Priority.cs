public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("bob,", 10);
        priorityQueue.Enqueue("jim", 9);
        priorityQueue.Enqueue("sally", 6);
        priorityQueue.Enqueue("Noel", 14);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}