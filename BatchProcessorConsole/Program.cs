using BatchProcessorConsole;
using DBClassLibrary;
using DBClassLibrary.Models;
using APICall;
using JSONParser;

TrackerContext context = new TrackerContext();
Repositoryclass obj = new Repositoryclass(context);
Header h =obj.GetHeader();
APICall.APICall api = new APICall.APICall();
string result =await api.GetData(h);
JSONParser.JSONParser parser = new JSONParser.JSONParser();
Quotes quote = parser.parse(result);

obj.AddQuoteToDB(quote);

Console.WriteLine("quote writen in DBClassLibrary");