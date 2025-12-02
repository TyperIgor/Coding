// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



var listA = new List<int> { 2, 1, 3, 0 };
var listB = new List<int> { 1, 3, 2, 4 };
var listC = new List<int> { 4, 2, 5, 1 };




var maxValue = FindMaxVale(listA, listB, listC);

Console.WriteLine("Soma dos valores encontrados em B e C: " + maxValue);

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

    int idxA = 0; int idxBorC = 0, idxC = 0;

    var journeyBiggestValuesFoundedList = new List<int>(); 

    bool inListA = true;
    bool inListB = false;
    bool inListC = false;

    double maxValue = double.MinValue;

    while (true)
    {
        if ( (idxA >= listA.Count()) || (idxBorC >= listB.Count()) || (idxC >= listC.Count()))
            return journeyBiggestValuesFoundedList.Sum();

        if (inListA)
        {

            idxBorC = listA[idxA];
            currentListIndex = (currentListIndex + 1) % 4; // Cycles through 0,1,2,3,0,1,...

            if (currentListIndex + 1 == 4)
                inListC = true;
        }
        if (inListB)
        {

            if (listB[idxBorC] > maxValue)
            {
                maxValue = listB[idxBorC];
            }

            idxA = listB[idxBorC];
            currentListIndex = (currentListIndex + 1) % 4; // Cycles through 0,1,2,3,0,1,...
            journeyBiggestValuesFoundedList.Add((int)maxValue);

            journeyBiggestValuesFoundedList.RemoveAll(item => item < maxValue);
        }
        if (inListC)
        {

            idxC = listC[idxBorC];
            journeyBiggestValuesFoundedList.Add(idxC);
            currentListIndex = (currentListIndex + 1) % 4; // Cycles through 0,1,2,3,0,1,...

            idxA = idxC;

            journeyBiggestValuesFoundedList.RemoveAll(item => item < maxValue);

            inListC = false;
            inListB = true;
            inListA = false;
        }

        inListA = !inListA;
        inListB = !inListB;
    }
}



























var res = FormatNewspaper(
    new string[][]
    {
        new string[] { "This", "is", "an", "example", "of", "text", "justification." },
        new string[] { "Another", "paragraph", "goes", "here." }
    },
    16
);


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




var test = solution(new int[] { 1, 5, 4, 10, 9 }, 3);

Console.WriteLine(test);



static int solution(int[] heights, int viewingGap)
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