using TestesUnitarios.Desafio.Console.Services;
using Xunit;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornarQuantidadeCaracteresDaPalavraMatrix()
    {
        // * IMPLEMENTADO *

        // Arrange
        var texto = "matrix";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // * IMPLEMENTADO *
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        // * IMPLEMENTADO *
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        // * IMPLEMENTADO *
        Assert.False(resultado);
    }

    // * IMPLEMENTADO *
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // * IMPLEMENTADO *

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
