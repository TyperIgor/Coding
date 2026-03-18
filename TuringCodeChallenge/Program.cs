// See https://aka.ms/new-console-template for more information
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TuringCodeChallenge.BinarySearch;



BinarySearchImp.BinarySearchIterative(new int[] { 1, 2, 3, 4, 5,6,7,8,9 }, 7);

//CreateKeywordIndex(new string[] {"test test software development"});
static Dictionary<string, List<int>> CreateKeywordIndex(string[] docs)
{
    var index = new Dictionary<string, List<int>>();

    for (int i = 0; i < docs.Length; i++)
    {
        var words = docs[i].Split(' ');
        foreach (var word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                if (!index.TryGetValue(word, out var docIndices))
                {
                    docIndices = new List<int>();
                    index.Add(word, docIndices);
                }
                docIndices.Add(i);
            }
        }
    }

    return index;
}













static void SortCharacters(string input)
{
    char[] chars = input.ToCharArray();
    Array.Sort(chars);
    string sorted = new string(chars);

    HashSet<string> sortedArrayAnagram = new HashSet<string>();

    sortedArrayAnagram.Add(sorted);
}





static int OptimizedSolutionMultipleOfThreeAndFive()
{
    int limit = 10;
    limit -=1;
    int sum = 0;
    int a = 3; int b = 5;

    int total = AritmeticExpression(3) + AritmeticExpression(5) - AritmeticExpression(15);

    int AritmeticExpression(int divisor)
    {
        var n = limit / divisor;

        return divisor * (n * (n + 1)) / 2;
    }

    return total;
}



//int[] array = new int[] { 1, 2, 3, 4, 5 };

//var result = TwoSumT(array, 9);

int[] arr = { 10, 5, 2, 7, 1, -10 };
int k = 15;

Console.WriteLine("Longest SubArray:", longestPrefixSubarray(arr, k));
















bool Palindrome(string texto)
{


    if (string.IsNullOrWhiteSpace(texto))
        return false;

    texto = texto.ToLower();

    int inicio = 0;
    int fim = texto.Length - 1;

    while (inicio < fim)
    {
        if (texto[inicio] != texto[fim])
            return false;

        inicio++;
        fim--;
    }

     return true;
}



static string LongestPalindrome(string s)
{
    if (string.IsNullOrEmpty(s)) return "none";

    int start = 0;
    int maxLength = 0;

    for (int i = 0; i < s.Length; i++)
    {
        ExpandFromCenter(s, i, i, ref start, ref maxLength);
        ExpandFromCenter(s, i, i + 1, ref start, ref maxLength);
    }

    if (maxLength < 3)
        return "none";

    return s.Substring(start, maxLength);
}

static void ExpandFromCenter(string s, int left, int right, ref int start, ref int maxLength)
{
    while (left >= 0 && right < s.Length && s[left] == s[right])
    {
        int length = right - left + 1;

        if (length > maxLength)
        {
            start = left;
            maxLength = length;
        }

        left--;
        right++;
    }
}



static string SearchingChallenge(string str)
{
    string varOcg = "";     // maior palíndromo encontrado
    int varFiltersCg = 0;   // tamanho do maior palíndromo

    // Função auxiliar para expandir em torno do centro
    string Expand(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return s.Substring(left + 1, right - left - 1);
    }

    for (int i = 0; i < str.Length; i++)
    {
        // Palíndromo com centro em i (ímpar)
        string p1 = Expand(str, i, i);
        if (p1.Length > varFiltersCg)
        {
            varFiltersCg = p1.Length;
            varOcg = p1;
        }

        // Palíndromo com centro entre i e i+1 (par)
        string p2 = Expand(str, i, i + 1);
        if (p2.Length > varFiltersCg)
        {
            varFiltersCg = p2.Length;
            varOcg = p2;
        }
    }

    if (varOcg.Length <= 2)
        return "none";

    return varOcg;
}










//solutionMostZero(new int[] { 4, 7, 5, 0, 0, 2, 8, 9 });

static int solutionMostZero(int[] numbers)
{

    var mostZeroClosest = 0;

    var lastIdx = 0;

    var i = 0;

    mostZeroClosest = numbers[i];

    var result = mostZeroClosest;


    while (i <= numbers.Length - 1)
    {
        if (numbers[i] == 0)
        {
            i++;
            continue;
        }


        if (numbers[i] < mostZeroClosest)
        {
            mostZeroClosest = numbers[i];
            result += mostZeroClosest;
        }

        numbers[i] = numbers[i] - mostZeroClosest;

        if (numbers[i] != 0)
        {
            continue;
        }


        i++;
    }

    return result;
}   


int[] solution(int[] diffs)
{
    var actualValue = 0;
    var lastMaxValue = 0;

    var initialRating = 1500;

    lastMaxValue = initialRating;
    actualValue = initialRating;

    for (int i = 0; i <= diffs.Length - 1;  i++)
    {
        if (diffs[i] < 0)
        {
            initialRating += diffs[i];
            actualValue = initialRating;
        }

        if (diffs[i] > 0)
        {
            if (initialRating + diffs[i] > lastMaxValue)
                lastMaxValue = initialRating + diffs[i];


            initialRating += diffs[i];
            actualValue = initialRating;

        }
    }

    return new int[] { lastMaxValue, actualValue };
}










static List<int> Solve(int[] arrayA, int[] arrayB)
{
    int idxA = 1; int idxB = 0;
    bool inListA = true;
    bool inListB = false;
    List<int> visitedPosit = new List<int>();

    while (true)
    {
        if (inListA)
        {

            idxB = arrayA[idxA-1];

        }
        if (inListB)
        {
        
            idxA = arrayB[idxB-1];

             if (visitedPosit.Contains(idxB))
                return visitedPosit;

            visitedPosit.Add(idxB);

        }

        inListA = !inListA;

    }
}



static int FindMaxVale(List<int> listA, List<int> listB, List<int> listC)
{
    int currentListIndex = 0; // Start at listA

    int idxA = 0; int idxBorC = 0, positionValue = 0;
    var hash = new HashSet<string>();

    var journey = new List<List<int>> { listA, listB, listA, listC };

    double maxValueB = 0;
    double maxValueC = 0;

    bool inListB = false;
    bool inListC = false;

    while(true)
    {
        if (inListB)
        {
            if (hash.Contains($"{currentListIndex},{idxBorC}"))
            {
                return (int)(maxValueB + maxValueC);
            }

            if (idxBorC >= listB.Count())
                return (int)(maxValueB + maxValueC);

            positionValue = journey[currentListIndex][idxBorC];

            hash.Add($"{currentListIndex},{idxBorC}");

            idxA = positionValue;

            if (listB[idxBorC] > maxValueB)
            {
                maxValueB = listB[idxBorC];
            }

            inListB = !inListB;
            currentListIndex = (currentListIndex + 1) % 4;

            continue;
        }
        if (inListC)
        {
            if (hash.Contains($"{currentListIndex},{idxBorC}"))
            {
                return (int)(maxValueB + maxValueC);
            }

            if (idxBorC >= listC.Count())
                return (int)(maxValueB + maxValueC);

            positionValue = journey[currentListIndex][idxBorC];

            hash.Add($"{currentListIndex},{idxBorC}");

            idxA = positionValue;

            if (journey[currentListIndex][idxBorC] > maxValueC)
            {
                maxValueC = journey[currentListIndex][idxBorC];
            }

            currentListIndex = (currentListIndex + 1) % 4;

            inListC = !inListC;

            continue;
        }
        else
        {
            if (hash.Contains($"{currentListIndex},{idxA}"))
            {
                return (int)(maxValueB + maxValueC);
            }

            if (idxA >= listA.Count())
                return (int)(maxValueB + maxValueC);

            positionValue = journey[currentListIndex][idxA];

            idxBorC = positionValue;

            hash.Add($"{currentListIndex},{idxA}");

            currentListIndex = (currentListIndex + 1) % 4;

            if (currentListIndex == 3)
            {
                inListC = true;
                continue;
            }

            inListB = !inListB;
        }
    }

    return 0;
}





int[,] matrix = { { 4, 4, 4, 4 },
                  { 1, 4, 4, 4 },
                  { 4, 1, 4, 4 },
                  { 4, 4, 0, 4 }
                };


static bool SearchMatrix(int[,] mtx, int target)
{

    int rows = mtx.GetLength(0);
    int cols = mtx.GetLength(1);
    int row = 0, col = 0;

    var valuesConstantArray = new ArrayList
    {
        mtx[row, col]
    };
    while (row < rows && col < cols)
    {
        while (col + 1 < cols)
        {
            if (valuesConstantArray.Contains(mtx[row + 1, col + 1]))
            {
                row++;
                col++;
            }
            //else
            //{
            //    col++;
            //    valuesConstantArray.Add(mtx[row, col]);
            //    break;
            //}
        }

        if (!(col + 1 < cols)) // finished check all collums 
        {
            col = 0;
            row++;
            valuesConstantArray.Add(mtx[row, col]);
        }

        if (row + 1 >= rows)
        {
            return false;
        }
    }

    return false;
}






















//var res = FormatNewspaper(
//    new string[][]
//    {
//        new string[] { "This", "is", "an", "example", "of", "text", "justification." },
//        new string[] { "Another", "paragraph", "goes", "here." }
//    },
//    16
//);


static string[] FormatNewspaper(string[][] paragraphs, int width)
{
    List<string> lines = new List<string>();

    foreach (var paragraph in paragraphs)
    {
        string currentLine = "";

        foreach (var chunk in paragraph)
        {
            if (currentLine.Length == 0)
            {
                // first chunk on the line
                currentLine = chunk;
            }
            else
            {
                // adding space + chunk
                string attempt = currentLine + " " + chunk;

                if (attempt.Length > width)
                {
                    // line full → center it, store it, start new line
                    lines.Add(Center(currentLine, width));
                    currentLine = chunk;
                }
                else
                {
                    currentLine = attempt;
                }
            }
        }

        // Add last line of the paragraph
        if (currentLine.Length > 0)
            lines.Add(Center(currentLine, width));
    }

    // Add border
    string border = new string('*', width + 2);
    List<string> framed = new List<string> { border };

    foreach (var line in lines)
    {
        framed.Add("*" + line + "*");
    }

    framed.Add(border);
    return framed.ToArray();
}

// Centers text according to the rules described
static string Center(string text, int width)
{
    int leftover = width - text.Length;

    int left = leftover / 2;
    int right = leftover - left; // extra space (if odd) goes to the right

    return new string(' ', left) + text + new string(' ', right);
}




static int solsution(int[] heights, int viewingGap)
{
    int n = heights.Length;
    int minDiff = int.MaxValue;

    for (int a = 0; a < n; a++)
    {
        // b must satisfy b >= a + viewingGap
        for (int b = a + viewingGap; b < n; b++)
        {
            int diff = Math.Abs(heights[a] - heights[b]);
            if (diff < minDiff)
                minDiff = diff;
        }
    }

    return minDiff;
}












static int MinutesSinceLastDeparture(string[] departureTimes, string currentTime)
{
    int current = ToMinutes(currentTime);
    int lastDeparture = -1;

    foreach (var time in departureTimes)
    {
        int dep = ToMinutes(time);

        // departure happened earlier today
        if (dep <= current && dep > lastDeparture)
            lastDeparture = dep;
    }

    // If no departure happened yet today → use yesterday's last departure
    if (lastDeparture == -1)
    {
        int latest = departureTimes
            .Select(t => ToMinutes(t))
            .Max();

        // minutes since yesterday's last departure
        return current + (24 * 60 - latest);
    }

    return current - lastDeparture;
}

static int ToMinutes(string time)
{
    var parts = time.Split(':');
    return int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
}

string[] CreateSquareFrame(int n)
{
    string[] result = new string[n];

    for (int i = 0; i < n; i++)
    {
        if (i == 0 || i == n - 1)
        {
            // Top and bottom borders
            result[i] = new string('*', n);
        }
        else
        {
            // Middle rows
            result[i] = "*" + new string(' ', n - 2) + "*";
        }
    }

    return result;
}




















int[] exampleArray = new int[] { 10, 20, 30, 40, 50 };
ModifyArray(exampleArray);


static void ModifyArray(int[] myArray)
{
    // Replace the second element (index 1) with 100
    myArray[1] = 100;

    // Create a new array with the modified elements and an additional element 200
    int[]updatedArray = new int[myArray.Length+1];

    Array.Copy(myArray, updatedArray, myArray.Length);

    updatedArray[updatedArray.Length - 1] = 200;

    // Print the modified array
    Console.WriteLine(string.Join(", ", updatedArray));
 }






static int FindMissingNumber(int[] arr)
{
    int n = arr.Length + 1;
    int expectedSum = n * (n + 1) / 2;
    int actualSum = arr.Sum();
    return expectedSum - actualSum;
}


int CountOccurrences(int[] nums, int target)
{
    return nums.Count(n => n == target);
}


static string GetJsonFromUrl(string url)
{
    try
    {
        HttpClient client = new HttpClient();
        string result = client.GetStringAsync(url).Result;
        Console.WriteLine($"json from url:{result}");
        var jsonWithoutValidKeys = RemoveNotValidKeysFromInputJson(result);
        Console.WriteLine(JsonConvert.SerializeObject(jsonWithoutValidKeys));
        return JsonConvert.SerializeObject(jsonWithoutValidKeys);
    }
    catch (Exception)
    {
        throw;
    }
}

static Dictionary<string, object> RemoveNotValidKeysFromInputJson(string inputJsonCoderbyte)
{
    //var alignJsonformats = JsonConvert.SerializeObject(inputJsonCoderbyte);

    var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(inputJsonCoderbyte);
    var hashKeysToRemove = new List<string> { "", "-", "N/A", "n/a" };
    Dictionary<string, object> resultDictionary = new();

    foreach (var item in data)
    {
        var key = item.Key;
        var value = item.Value;
        switch (value)
        {
            case long:
            {
                resultDictionary.Add(key, value);
                break;
            }

            case string str:
            {
                if (!hashKeysToRemove.Contains(str))
                    resultDictionary.Add(key, str);
                break;
            }

            case JArray jArray:
            {
                var arrResult = new List<string>();
                foreach (var obj in jArray)
                {
                    var itemStr = (string)obj!;
                    if (!hashKeysToRemove.Contains(itemStr))
                    {
                        arrResult.Add(itemStr);
                    }
                }
                resultDictionary.Add(key, arrResult);
                break;
            }

            default:
            {
                var json2 = JsonConvert.SerializeObject(value);
                var result = RemoveNotValidKeysFromInputJson(json2);
                resultDictionary.Add(key, result);
                break;
            }
        }
    }

    return resultDictionary;
}


static int[] TwoSum(int[] nums, int target)
{
    var hashPairSumValues = new HashSet<int[]>();

    int i = nums.Length - 1;
	while (i >= 0)
	{
        int value = target - nums[i];

        nums[i] = 0;

        int idx = Array.BinarySearch(nums, value);

        if (idx < 0)
        {
            i--;
            continue;
        }

        return new int[] { idx, i };
    }

    return new int[0];
}

static int[] NewTwoSumSolution(int[] nums, int target) //target = 8 //
{
    var DictPairSumValues = new Dictionary<int, int>();

    int i = 0;
    while (i <= nums.Length - 1)
    {
        int value = target - nums[i];

        if (DictPairSumValues.ContainsKey(value))
            return new int[] { DictPairSumValues[value], i };

        DictPairSumValues[nums[i]] = i;
        i++; 
    }

    return new int[0];
}

static int[] TwoSumFirstOne(int[] nums, int target)
{
    // brute force
    int i = 0;
    int j = 0;

    while (i <= nums.Length - 1)
    {
        j++;

        if (nums[i] + nums[j] == target)
            return new int[] { i, j };

        if (j == nums.Length - 1)
        {
            j = 0;
            i++;
            j += i;
        }
    }

    return new int[] { 0 };
}

static int longestPrefixSubarray(int[] arr, int k)
{
    Dictionary<int, int> mp = new Dictionary<int, int>();
    int res = 0;
    int prefSum = 0;

    for (int i = 0; i < arr.Length; ++i)
    {
        prefSum += arr[i];

        // Check if the entire prefix sums to k
        if (prefSum == k)
        {
            res = i + 1;
            if (!mp.ContainsKey(prefSum))
                mp[prefSum] = i;

            continue;
        }
        else if (mp.ContainsKey(prefSum - k))
            res = Math.Max(res, i - mp[prefSum - k]);

        // Store only first occurrence index of prefSum
        if (!mp.ContainsKey(prefSum))
            mp[prefSum] = i;
    }

    return res;
}


static int longestSubarray(int[] arr, int k)
{
    int res = 0;

    for (int i = 0; i < arr.Length; i++)
    {

        // Sum of subarray from i to j
        int sum = 0;
        for (int j = i; j < arr.Length; j++)
        {
            sum += arr[j];

            // If subarray sum is equal to k
            if (sum == k)
            {

                // find subarray length and update result
                int subLen = j - i + 1;
                res = Math.Max(res, subLen);
            }
        }
    }

    return res;
}

static int[] TwoSumT(int[] nums, int target) 
{
    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (map.ContainsKey(complement))
        {
            return new int[] { map[complement], i };
        }

        map[nums[i]] = i;
    }
    return new int[0];
}

static int[] FindErrorNums(int[] nums)
{
    HashSet<int> numsReplited = new();

    for (int i = 0; i <= nums.Length-1; i++)
    {
        if (!numsReplited.Add(nums[i]))
            return new int[] { nums[i], i+=1 };

        numsReplited.Add(nums[i]);
    }

    return new int[0];  
}