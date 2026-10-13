// Auto-generated Solvers for Task: csharp_52
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_52.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int MaxFill(List<List<int>> grid, int capacity)
    {
        int result = 0;

        foreach (var row in grid)
        {
            int ones = 0;
            for (int i = 0; i < row.Count; i++)
                ones += row[i];

            result += (ones + capacity - 1) / capacity;
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_52.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
public static int MaxFill(List<List<int>> grid, int capacity)
{
if (grid == null || grid.Count == 0 || capacity <= 0)
{
return 0;
}


    int totalBucketsNeeded = 0;

    foreach (var well in grid)
    {
        int waterInWell = 0;
        foreach (int unit in well)
        {
            if (unit == 1)
            {
                waterInWell++;
            }
        }

        if (waterInWell > 0)
        {
            // Calculate how many times the bucket needs to be lowered for this specific well.
            // This is equivalent to Ceiling(waterInWell / capacity).
            int drops = (waterInWell + capacity - 1) / capacity;
            totalBucketsNeeded += drops;
        }
    }

    return totalBucketsNeeded;
}



}
}

namespace Benchmarks.csharp_52.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int MaxFill(List<List<int>> grid, int capacity)
    {
        return grid.Sum(row => (int)Math.Ceiling((double)row.Sum() / capacity));
    }
}
}

namespace Benchmarks.csharp_52.Grok
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int MaxFill(List<List<int>> grid, int capacity)
    {
        int totalLowerings = 0;
        foreach (var well in grid)
        {
            int water = well.Sum();
            if (water > 0)
            {
                totalLowerings += (water + capacity - 1) / capacity;
            }
        }
        return totalLowerings;
    }
}
}

namespace Benchmarks.csharp_52.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int MaxFill(List<List<int>> grid, int capacity)
    {
        int totalWater = 0;
        foreach (var well in grid)
        {
            totalWater += well.Sum();
        }

        if (totalWater == 0)
        {
            return 0;
        }

        int trips = 0;
        while (totalWater > 0)
        {
            int currentTripWater = 0;
            foreach (var well in grid)
            {
                int waterInWell = well.Sum();
                if (waterInWell > 0)
                {
                    int extracted = Math.Min(waterInWell, capacity - currentTripWater);
                    currentTripWater += extracted;
                    totalWater -= extracted;
                }
            }
            trips++;
        }

        return trips;
    }
}
}

namespace Benchmarks.csharp_52.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int MaxFill(List<List<int>> grid, int capacity)
    {
        int totalWater = 0;
        
        foreach (var row in grid)
        {
            totalWater += row.Sum();
        }
        
        if (totalWater == 0)
        {
            return 0;
        }
        
        return (int)Math.Ceiling((double)totalWater / capacity);
    }
}
}

namespace Benchmarks.csharp_52.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static int MaxFill(List<List<int>> grid, int capacity) 
    {
        int count = 0;
        foreach (var well in grid) 
        {
            int waterUnits = well.Sum();
            count += (int)Math.Ceiling((double)waterUnits / capacity);
        }
        return count;
    }
}
}
