# Number2Word ![Nuget](https://img.shields.io/nuget/v/Navaidh.Util.Number2Word?logo=nuget) [![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)


## Summary

Number2Word is a .NET library that provides a convenient way to convert numbers into equivalent words representing their significance. With this library, you can easily convert numeric values into words, which can be helpful in various applications such as invoice generation, financial reports, and text-to-speech systems.

## Installation

You can install the Number2Word library via the NuGet package manager or .NET CLI.

### NuGet Package Manager

1. Open the NuGet Package Manager in Visual Studio.
2. Search for "Number2Word" in the package search bar.
3. Click on the "Number2Word" package from the search results.
4. Select the desired project(s) from the solution to install the package.
5. Click the "Install" button to add the package to your project.

### .NET CLI

Open a command prompt or terminal and run the following command:

```shell
dotnet add package Number2Word
```

## Usage

Using Number2Word is straightforward. Follow the steps below to convert a number to its significant word representation.

1. Add a reference to the Number2Word namespace in your code file:

```csharp
using Navaidh.Number2Word;
```

2. Use the `ConvertToWords` method to convert a number into its word representation:

```csharp
string word = Converter.ConvertToWords(123456);
Console.WriteLine(word); // Output: "One Hundred Twenty Three Thousands Four Hundred Fifty Six."
```

## Examples

Here are a few examples to demonstrate the usage of Number2Word:

```csharp

string word1 = Converter.ConvertToWords(987654321);
Console.WriteLine(word1); // Output: "Nine Hundred Eighty Seven Millions Six Hundred Fifty Four Thousands Three Hundred Twenty One."

string word3 = Converter.ConvertToWords(14524);
Console.WriteLine(word3); // Output: "Fourteen Thousands Five Hundred Twenty Four."
```
## Roadmap

- Additional language support: Extend the library to support number-to-word conversion for multiple languages.
- Add Custom Separators: Allow users to customize the separators used in the word representation of numbers.

## Bugs

- Not returning Zero: The current implementation does not handle the number zero appropriately.
 
## License

Number2Word is released under the [MIT License](https://github.com/NavaidhInnovations/Number2Word/blob/master/LICENSE).

## Contributing

Contributions to Number2Word are welcome! If you find any issues or have suggestions, or want to add new features, please open an issue or submit a pull request on the [GitHub repository](https://github.com/NavaidhInnovations/Number2Word).

## Acknowledgements

Number2Word is inspired by similar libraries and projects that provide number-to-word conversion functionality. We would like to acknowledge their contributions and the open-source community for their continuous support.

## Contact

For any questions, concerns, or inquiries, please contact the maintainer of Number2Word:

- Maintainer: [Navaidh Innovations](mailto:navaidhinnovations@gmail.com)

## References

- [GitHub Repository](https://github.com/NavaidhInnovations/Number2Word)
