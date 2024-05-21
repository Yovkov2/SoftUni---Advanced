
        int n = int.Parse(Console.ReadLine());
        string racingNumber = Console.ReadLine();

        char[,] raceRoute = new char[n, n];
        (int x, int y)[] tunnels = new (int, int)[2];
        int tunnelIndex = 0;

        for (int i = 0; i < n; i++)
        {
            var row = Console.ReadLine().Split().Select(char.Parse).ToArray();
            for (int j = 0; j < n; j++)
            {
                raceRoute[i, j] = row[j];
                if (raceRoute[i, j] == 'T')
                {
                    tunnels[tunnelIndex++] = (i, j);
                }
            }
        }

        (int x, int y) position = (0, 0);
        int distance = 0;

        string command;
        bool finished = false;

        while ((command = Console.ReadLine()) != "End")
        {
            (int x, int y) newPosition = position;

            switch (command)
            {
                case "left":
                    newPosition.y -= 1;
                    break;
                case "right":
                    newPosition.y += 1;
                    break;
                case "up":
                    newPosition.x -= 1;
                    break;
                case "down":
                    newPosition.x += 1;
                    break;
            }

            char newCell = raceRoute[newPosition.x, newPosition.y];

            if (newCell == 'F')
            {
                distance += 10;
                position = newPosition;
                finished = true;
                break;
            }
            else if (newCell == 'T')
            {
                distance += 30;
                raceRoute[tunnels[0].x, tunnels[0].y] = '.';
                raceRoute[tunnels[1].x, tunnels[1].y] = '.';
                newPosition = newPosition == tunnels[0] ? tunnels[1] : tunnels[0];
            }
            else
            {
                distance += 10;
            }

            position = newPosition;
        }

        if (finished)
        {
            Console.WriteLine($"Racing car {racingNumber} finished the stage!");
        }
        else
        {
            Console.WriteLine($"Racing car {racingNumber} DNF.");
        }

        Console.WriteLine($"Distance covered {distance} km.");
        raceRoute[position.x, position.y] = 'C';

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(raceRoute[i, j]);
            }
            Console.WriteLine();
        }