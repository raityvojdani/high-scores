using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace high_scores;
public class HighScores
{
    private List<int> _scores;
    private List<int> _topThree= new List<int>();

    public HighScores(List<int> list)
    {
        _scores = list;
    }

    public List<int> Scores()
    {
        return _scores;
    }

    public int Latest()
    {
        return _scores[_scores.Count-1];
    }

    public int PersonalBest()
    {
      return  _scores.Max();
    }

    public List<int> PersonalTopThree()
    {
        
        _topThree = _scores.OrderByDescending(score => score).Take(3).ToList();
        return _topThree;
    }
}