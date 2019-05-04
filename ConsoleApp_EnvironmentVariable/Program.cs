using System;
using System.Collections;

namespace ConsoleApp_EnvironmentVariable {
  class Program {
    static void Main(string[] args) {

      var variableName = "password";
      var variableValue = "abcd1234";

      var environmentVariable = Environment.GetEnvironmentVariable(variableName);
      if (environmentVariable == null) {
        Environment.SetEnvironmentVariable(variableName,variableValue,EnvironmentVariableTarget.User);
      }

      var variables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);

      foreach (DictionaryEntry item in variables) {
        Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
      }

      Console.Read();
    }
  }
}
