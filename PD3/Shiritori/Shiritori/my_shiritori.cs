using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiritori
{
    internal class my_shiritori
    {
        List<string> list;
        bool gameover;
        public my_shiritori()
        {
            list = new List<string>();
            gameover = false;
        }

        public List<string> play(string word)
        {
            bool AlreadyExist=false;
            for(int i=0; i<list.Count; i++)
            {
                if (list[i] == word)
                {
                    AlreadyExist = true;
                }
            }
            if(list.Count == 0) {
                list.Add(word);
                return list;
            }
            else if (list[list.Count - 1][list[list.Count - 1].Length - 1] == word[0] &&  !AlreadyExist )
            {
                list.Add(word);
                return list;
            }
            List<string> result = new List<string>();
            gameover = true;
            result.Add("Game Over");
            return result;
        }
        public string restart() {

            list.Clear();
            gameover = false;
            return "Game restarted";

        }


    }
}
