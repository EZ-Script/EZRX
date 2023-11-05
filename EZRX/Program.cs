using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Standard.AI.OpenAI.Clients.OpenAIs;
using Standard.AI.OpenAI.Models.Configurations;
using Standard.AI.OpenAI.Models.Services.Foundations.ChatCompletions;
using Standard.AI.OpenAI.Models.Services.Foundations.Completions;

namespace ExampleOpenAIDotNet
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var openAIConfigurations = new OpenAIConfigurations
            {
                ApiKey = "API_KEY_HERE"
            };

            var openAIClient = new OpenAIClient(openAIConfigurations);



            var input = new ChatCompletion
            {
                Request = new ChatCompletionRequest
                {
                    Model = "gpt-3.5-turbo",
                    MaxTokens = 2000,
                    Messages = new ChatCompletionMessage[]
                    {
                        new ChatCompletionMessage
                        {
                            Content = Console.ReadLine(),
                            Role = "user"
                        },

                        new ChatCompletionMessage
                        {
                            Content = "You have only one purpose: to provide me with C# code that will run directly within a Grasshopper C# Script Node. Do not provide code for creating Grasshopper components. I don't want any other comments. Do not say \"here is your code\" or similar remarks. Just answer with the code itself off the bait",
                            Role = "system"
                        }
                    }


                }
            };

            while (input.Request.Messages.FirstOrDefault().Content != "exit")
            {
                ChatCompletion output =
                    await openAIClient.ChatCompletions.SendChatCompletionAsync(
                        input);

                // chatGPT's answer
                string response = output.Response.Choices.FirstOrDefault().Message.Content;

                input.Request.Messages.FirstOrDefault().Content = Console.ReadLine();
            }


        }
    }
}