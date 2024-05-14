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
        //scenario: dequeue prints message saying there isn't anything in queue when called.
        Console.WriteLine("Test 1");
        Console.WriteLine(priorityQueue.Dequeue());
        //defects found: none.


        // Test 2
        // Scenario:prints out the queue in the enqueue order
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("bob,", 2);
        priorityQueue.Enqueue("jim", 9);
        priorityQueue.Enqueue("sally", 9);
        priorityQueue.Enqueue("noel", 7);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: none 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Dequeue removes items from queue and returns highest priority also picks the highest priority that is first in vs the other one in queue.
        // Expected Result: prints out the highest priority in queue.
        Console.WriteLine("Test 3");
        var highPrio = priorityQueue.Dequeue();
        Console.WriteLine(highPrio);
        // Defect(s) Found: 
        // wouldn't pick the highest prioriy but would pick the last item in queue to print out. 
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}