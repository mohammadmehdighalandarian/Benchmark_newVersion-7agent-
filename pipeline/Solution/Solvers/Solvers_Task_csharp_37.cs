// Auto-generated Solvers for Task: csharp_37
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_37.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<List<int>> GetRow(List<List<int>> lst, int x)
    {
        var result = new List<List<int>>();

        for (int i = 0; i < lst.Count; i++)
        {
            for (int j = 0; j < lst[i].Count; j++)
            {
                if (lst[i][j] == x)
                {
                    result.Add(new List<int> { i, j });
                }
            }
        }

        return result
            .OrderBy(p => p[0])
            .ThenByDescending(p => p[1])
            .ToList();
    }
}
}

namespace Benchmarks.csharp_37.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// You are given a 2 dimensional data, as a nested lists,
    /// which is similar to matrix, however, unlike matrices,
    /// each row may contain a different number of columns.
    /// Given lst, and integer x, find integers x in the list,
    /// and return list of tuples, [(x1, y1), (x2, y2) ...] such that
    /// each tuple is a coordinate - (row, columns), starting with 0.
    /// Sort coordinates initially by rows in ascending order.
    /// Also, sort coordinates of the row by columns in descending order.
    /// </summary>
    public static List<List<int>> GetRow(List<List<int>> lst, int x)
    {
        List<List<int>> coordinates = new List<List<int>>();

        if (lst == null)
        {
            return coordinates;
        }

        // Iterate through rows in ascending order (0 to N-1)
        for (int r = 0; r < lst.Count; r++)
        {
            List<int> columnIndices = new List<int>();
            
            // Find all columns in current row where value matches x
            for (int c = 0; c < lst[r].Count; c++)
            {
                if (lst[r][c] == x)
                {
                    columnIndices.Add(c);
                }
            }

            if (columnIndices.Count > 0)
            {
                // Sort coordinates of the specific row by columns in descending order
                columnIndices.Sort((a, b) => b.CompareTo(a));

                foreach (int colIndex in columnIndices)
                {
                    coordinates.Add(new List<int> { r, colIndex });
                }
            }
        }

        return coordinates;
    }
}
}

namespace Benchmarks.csharp_37.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<List<int>> GetRow(List<List<int>> lst, int x)
    {
        var result = new List<List<int>>();
        for (int r = 0; r < lst.Count; r++)
        {
            var cols = lst[r].Select((val, col) => new { val, col })
                             .Where(a => a.val == x)
                             .OrderByDescending(a => a.col)
                             .Select(a => new List<int> { r, a.col });
            result.AddRange(cols);
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_37.Grok
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<List<int>> GetRow(List<List<int>> lst, int x)
    {
        List<List<int>> coords = new List<List<int>>();
        for (int i = 0; i < lst.Count; i++)
        {
            for (int j = 0; j < lst[i].Count; j++)
            {
                if (lst[i][j] == x)
                {
                    coords.Add(new List<int> { i, j });
                }
            }
        }
        coords = coords.OrderBy(c => c[0]).ThenByDescending(c => c[1]).ToList();
        return coords;
    }
}
}

namespace Benchmarks.csharp_37.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<List<int>> GetRow(List<List<int>> lst, int x)
    {
        var result = new List<List<int>>();
        for (int row = 0; row < lst.Count; row++)
        {
            var columns = lst[row]
                .Select((value, col) => new { Value = value, Col = col })
                .Where(item => item.Value == x)
                .OrderByDescending(item => item.Col)
                .Select(item => item.Col)
                .ToList();

            foreach (var col in columns)
            {
                result.Add(new List<int> { row, col });
            }
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_37.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<List<int>> GetRow(List<List<int>> lst, int x)
    {
        var result = new List<List<int>>();
        
        for (int row = 0; row < lst.Count; row++)
        {
            var columns = new List<int>();
            for (int col = 0; col < lst[row].Count; col++)
            {
                if (lst[row][col] == x)
                {
                    columns.Add(col);
                }
            }
            
            // Sort columns in descending order
            columns.Sort((a, b) => b.CompareTo(a));
            
            foreach (var col in columns)
            {
                result.Add(new List<int> { row, col });
            }
        }
        
        return result;
    }
}
}

namespace Benchmarks.csharp_37.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<List<int>> GetRow(List<List<int>> lst, int x) 
    {
        var result = new List<(int, int)>();
        for (int i = 0; i < lst.Count; i++) 
        {
            for (int j = 0; j < lst[i].Count; j++) 
            {
                if (lst[i][j] == x) 
                {
                    result.Add((i, j));
                }
            }
        }
        throw new SyntaxErrorException();
    }
}
}
