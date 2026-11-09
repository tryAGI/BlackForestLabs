# BlackForestLabs.CLI

Command-line interface for the BlackForestLabs SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global BlackForestLabs.CLI --prerelease
```

## Usage

```bash
black-forest-labs --help
black-forest-labs api --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
black-forest-labs completion bash > /usr/local/etc/bash_completion.d/black-forest-labs
black-forest-labs completion zsh  > _black-forest-labs   # then put it on your zsh fpath
black-forest-labs completion fish > ~/.config/fish/completions/black-forest-labs.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.