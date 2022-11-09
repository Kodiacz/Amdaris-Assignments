using System.Text;

namespace AppTagInterpreter
{
    public class AmdarisTask
    {
        public static int TaskWithoutUsingSpan(string input)
        {
            string[] tagArray = input.Split("><");

            string currentTag;

            int count = 0;

            for (int i = 0; i < tagArray.Length; i++)
            {
                if (i == 0)
                {
                    currentTag = tagArray[i] + ">";
                }
                else if (i == tagArray.Length - 1)
                {
                    currentTag = "<" + tagArray[i];
                }
                else
                {
                    currentTag = "<" + tagArray[i] + ">";
                }

                if (currentTag == "<app>")
                {
                    count++;
                }
                else
                {
                    if (i == 0 || count == 0)
                    {
                        count++;
                        continue;
                    }

                    count--;
                }
            }

            return count;
        }

        public static int TaskWithUsingSpan(string input)
        {
            //“<app><app><app></app></app>” -> 1 // only one ‘<app>’ tag is not closed.
            //“<app></app></app><app><app>” -> 3 // one closing tag is not opened, two opening tags are not closed.
            //“</app><app><app></app></app>” -> 1 // one closing tag is not opened.

            List<string> openTags = new List<string>(); 
            List<string> closeTags = new List<string>(); 

            var inputAsSpan = input.AsSpan();
                
            for (int i = 0; i < input.Length; i++)
            {
                var chunk = inputAsSpan.Slice(i, 5);

                if (chunk.ToString() != "<app>")
                {

                    chunk = inputAsSpan.Slice(i, 6);
                    i += 5;

                    if (openTags.Count > 0)
                    {
                        openTags.RemoveAt(0);
                    }
                    else
                    {
                        closeTags.Add(chunk.ToString());
                    }

                    continue;
                }

                openTags.Add(chunk.ToString());

                i += 4;
            }

            return openTags.Count + closeTags.Count;
        }

        private static void StoreUnclosedTags(List<string> openTags, List<string> closedTags, string tag)
        {
            if (tag == "<app>")
            {
                openTags.Add(tag);
            }
            else
            {
                closedTags.Add(tag);
            }

        }
        
    }
}
