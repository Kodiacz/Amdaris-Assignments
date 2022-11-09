using AppTagInterpreter;
//“<app><app><app></app></app>” -> 1 // only one ‘<app>’ tag is not closed.
//“<app></app></app><app><app>” -> 3 // one closing tag is not opened, two opening tags are not closed.
//“</app><app><app></app></app>” -> 1 // one closing tag is not opened.

string input = "<app><app><app></app></app>";

Console.WriteLine("Without Span:");
int resultWihtoutSpan = AmdarisTask.TaskWithoutUsingSpan(input);
Console.WriteLine(resultWihtoutSpan);

Console.WriteLine("With Span:");
int resultWithSpan = AmdarisTask.TaskWithUsingSpan(input);
Console.WriteLine(resultWithSpan);

