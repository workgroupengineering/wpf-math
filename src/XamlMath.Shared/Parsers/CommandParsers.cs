using XamlMath.Atoms;
using XamlMath.Exceptions;

namespace XamlMath.Parsers;

/// <summary>A context that will be passed to the command parser.</summary>
/// <param name="Parser">TeX formula parser that calls the command.</param>
/// <param name="Formula">Current formula that is being constructed.</param>
/// <param name="Environment">An environment in which the command should be parsed.</param>
/// <param name="CommandSource">
/// Source of the current command: includes both the command name and the arguments.
/// </param>
/// <param name="CommandNameStartPosition">
/// A position inside of source where the command name start. Useful to provide the source information, not for
/// the parsing itself.
/// </param>
/// <param name="ArgumentsStartPosition">
/// A position inside of source where the command arguments start. Should be a parser start position.
/// </param>
internal record CommandContext(
    TexFormulaParser Parser,
    TexFormula Formula,
    ICommandEnvironment Environment,
    SourceSpan CommandSource,
    int CommandNameStartPosition,
    int ArgumentsStartPosition
);

internal class CommandProcessingResult
{
    /// <summary>A parsed atom.</summary>
    public Atom? Atom { get; }

    /// <summary>
    /// A position pointing to the part of the <see cref="CommandContext.CommandSource"/> where the parsing should
    /// proceed.
    /// </summary>
    public int NextPosition { get; }

    /// <summary>
    /// Controls how an atom generated by this command should be handled: should it be added to the end of an
    /// existing formula, or should it replace the formula completely.
    /// </summary>
    public AtomAppendMode AppendMode { get; }

    public CommandProcessingResult(Atom? atom, int nextPosition, AtomAppendMode appendMode = AtomAppendMode.Add)
    {
        Atom = atom;
        NextPosition = nextPosition;
        AppendMode = appendMode;
    }
}

/// <summary>
/// A parser for a particular command that should read the command name and its arguments and produce an
/// <see cref="Atom"/>, and also move the parser position towards the end.
/// </summary>
internal interface ICommandParser
{
    /// <summary>Parsing of the command arguments.</summary>
    /// <param name="context">The context of the command.</param>
    /// <returns>The parsing result, never <c>null</c>.</returns>
    /// <exception cref="TexParseException">Should be thrown on any error.</exception>
    CommandProcessingResult ProcessCommand(CommandContext context);
}
