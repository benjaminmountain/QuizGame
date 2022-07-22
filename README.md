# Unity Quiz Game

Add this code to the `settings.json` file to resolve problem with syntax highlighting using Tokyo Night theme for C#. If you want to make this change globally add the code to your global `settings.json` file.

``` Dart
"editor.tokenColorCustomizations": {
  "[Tokyo Night]": {
    "textMateRules": [
      {
        "scope": "entity.name.type",
        "settings": {
          "foreground": "#09e9dd"
        }
      }
    ]
  }
},
```

See [OmniSharp Configuration Options](https://github.com/OmniSharp/omnisharp-roslyn/wiki/Configuration-Options) to customize OmniSharp behavior. I use it to get rid of automatic newlines when formatting C# code on save.
