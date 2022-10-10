using NewString2;

Console.Write("Input sentence : ");
string sentence = Console.ReadLine();
SringFunctions myFunction = new SringFunctions();
int sentenceLength = myFunction.ReturnWords(sentence).Length;
for (int i = 0; i < sentenceLength; i++)
{
    Console.Write(myFunction.MyReverse(myFunction.ReturnWords(sentence)[i]) + " ");
}