# EZRX

This is a simple example of how to use the OpenAI API to create a chatbot using C#/.NET. The chatbot engages in a conversation with the user and the GPT-3.5 Turbo model provided by OpenAI. The output is a C# script that will run directly within a Grasshopper C# Script Node. 

Prerequisites

# Before using this code, make sure you have the following:

An OpenAI API key, which can be obtained from OpenAI.
# Getting Started

Clone this repository or create a new C# project in your preferred development environment.
Replace YOUR_API_KEY in the code with your actual OpenAI API key.
csharp
Copy code
var openAIConfigurations = new OpenAIConfigurations
{
    ApiKey = "YOUR_API_KEY"
};
# Build and run the program.
How It Works

This C# program allows you to have a conversation with the OpenAI GPT-3.5 Turbo model. Here's a breakdown of what the code does:

It sets up the OpenAI client with your API key.
It initializes a conversation with a system message and a user message.
It enters a loop where you can input messages as a user, and the program sends these messages to the OpenAI model.
The model responds with generated text, and the program prints the response.
The conversation continues until you enter "exit" as a message.
Conversational Format

This code follows the recommended conversational format provided by OpenAI, with a system message, alternating user and assistant messages. Here's the format:

```
csharp
Copy code
Messages = new ChatCompletionMessage[]
{
    new ChatCompletionMessage
    {
        Role = "system",  //this tell GPT how to behave
        Content = "You have only one purpose: to provide me with C# code that will run directly within a Grasshopper C# Script Node. "   
    },
    new ChatCompletionMessage
    {
        Role = "user",
        Content = "Your user input goes here."  
    }
}

```

csharp
Copy code
Messages = new ChatCompletionMessage[]
{
    new ChatCompletionMessage
    {
        Role = "system",  //this tell GPT how to behave
        Content = "You have only one purpose: to provide me with C# code that will run directly within a Grasshopper C# Script Node. "   
    },
    new ChatCompletionMessage
    {
        Role = "user",
        Content = "Your user input goes here."  
    }
}
The system message sets the behavior of the assistant, and you can alternate between user and assistant messages.

