public class SortArrays
{
    private List<int> _a = new List<int>() { 1, 3, 7, 50, 83, 100};
    private List<int> _b = new List<int>() { 6, 15, 71, 90, 93, 102};
    private List<int> _result;
    public List<int> Result => _result;

    public void DisplayResult()
    {
        string message = "[";
        foreach (var r in _result)
        {
            message += " " + r + ", ";
        }

        message += "]";
        Debug.Log(message);
    }
    public void UniteAndSort()
    {
        _result = new List<int>();
        foreach (var aItem in _a)
        {
            _result.Add(aItem);
        }

        foreach (var bItem in _b)
        {
            _result.Add(bItem);
        }
        int i, j, temp;
        bool swapped;
        for (i = 0; i < _result.Count - 1; i++) 
        {
            swapped = false;
            for (j = 0; j < _result.Count - i - 1; j++) 
            {
                if (_result[j] < _result[j + 1]) 
                {
                    temp = _result[j];
                    _result[j] = _result[j + 1];
                    _result[j + 1] = temp;
                    swapped = true;
                }
            }
            
            if (swapped == false)
            {
                break;
            }
                
        }
    }
}