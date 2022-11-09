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
            List<string> openTags = new List<string>(); 
            List<string> closeTags = new List<string>(); 

            var inputAsSpan = input.AsSpan();
                
            for (int i = 0; i < input.Length; i++)
            {
                // Slice method starts from i until the length of the open tag (<app>) which is 5
                var chunk = inputAsSpan.Slice(i, 5);

                // check if chunk is different from open tag (<app>). Because they are two situations: either
                // </app or <app>
                if (chunk.ToString() != "<app>")
                {
                    // Here we asign new value to the chunk which will be closing tag (</app>)
                    chunk = inputAsSpan.Slice(i, 6);

                    // and we skip the letters < / a p p > from input when we assign i 
                    i += 5;

                    // check if they are any open tags. If collection contais we should close the open tag by removing it
                    if (openTags.Count > 0)
                    {
                        openTags.RemoveAt(0);
                    }
                    // but if openTags collection is empty this means that we have a closing tag without open tag
                    else
                    {
                        closeTags.Add(chunk.ToString());
                    }

                    continue;
                }

                // if the above if statement is false that means we don't have a closing tag so we
                // add the open tag (<app>) here
                openTags.Add(chunk.ToString());

                i += 4;
            }

            // now we have the count from the left open tags and the left closing tags

            return openTags.Count + closeTags.Count;
        }
    }
}
