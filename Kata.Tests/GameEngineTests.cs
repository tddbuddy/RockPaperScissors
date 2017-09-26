using Kata.Prod;
using Kata.Prod.Moves;
using NUnit.Framework;

namespace Kata
{
    [TestFixture]
    public class GameEngineTests
    {
        [TestFixture]
        public class BasicRules
        {
            [TestFixture]
            public class Play
            {
                [TestFixture]
                public class WhenScissors
                {
                    [Test]
                    public void ShouldLooseToRock()
                    {
                        // Arrange
                        var expected = GameResult.Loose;
                        var player = new Scissors();
                        var opponent = new Rock();
                        var game = new GameEngine();
                        // Act
                        var actual = game.Play(player, opponent);
                        // Assert
                        Assert.AreEqual(expected, actual);
                    }

                    [Test]
                    public void ShouldBeatPaper()
                    {
                        // Arrange
                        var expected = GameResult.Win;
                        var player = new Scissors();
                        var opponent = new Paper();
                        var game = new GameEngine();
                        // Act
                        var actual = game.Play(player, opponent);
                        // Assert
                        Assert.AreEqual(expected, actual);
                    }

                    [Test]
                    public void ShouldDrawScissors()
                    {
                        // Arrange
                        var expected = GameResult.Draw;
                        var player = new Scissors();
                        var opponent = new Scissors();
                        var game = new GameEngine();
                        // Act
                        var actual = game.Play(player, opponent);
                        // Assert
                        Assert.AreEqual(expected, actual);
                    }
                }

                [TestFixture]
                public class WhenPaper
                {
                    [Test]
                    public void ShouldLooseToScissors()
                    {
                        // Arrange
                        var expected = GameResult.Loose;
                        var player = new Paper();
                        var opponent = new Scissors();
                        var game = new GameEngine();
                        // Act
                        var actual = game.Play(player, opponent);
                        // Assert
                        Assert.AreEqual(expected, actual);
                    }

                    [Test]
                    public void ShouldBeatRock()
                    {
                        // Arrange
                        var expected = GameResult.Win;
                        var player = new Paper();
                        var opponent = new Rock();
                        var game = new GameEngine();
                        // Act
                        var actual = game.Play(player, opponent);
                        // Assert
                        Assert.AreEqual(expected, actual);
                    }

                    [Test]
                    public void ShouldDrawPaper()
                    {
                        // Arrange
                        var expected = GameResult.Draw;
                        var player = new Paper();
                        var opponent = new Paper();
                        var game = new GameEngine();
                        // Act
                        var actual = game.Play(player, opponent);
                        // Assert
                        Assert.AreEqual(expected, actual);
                    }
                }

                // todo : hard to remember exact scenario when programming?
                [TestFixture]
                public class WhenRock
                {
                    [Test]
                    public void ShouldLooseToPaper()
                    {
                        // Arrange
                        var expected = GameResult.Loose;
                        var player = new Rock();
                        var opponent = new Paper();
                        var game = new GameEngine();
                        // Act
                        var actual = game.Play(player, opponent);
                        // Assert
                        Assert.AreEqual(expected, actual);
                    }

                    [Test]
                    public void ShouldBeatScissors()
                    {
                        // Arrange
                        var expected = GameResult.Win;
                        var player = new Rock();
                        var opponent = new Scissors();
                        var game = new GameEngine();
                        // Act
                        var actual = game.Play(player, opponent);
                        // Assert
                        Assert.AreEqual(expected, actual);
                    }

                    [Test]
                    public void ShouldDrawRock()
                    {
                        // Arrange
                        var expected = GameResult.Draw;
                        var player = new Rock();
                        var opponent = new Rock();
                        var game = new GameEngine();
                        // Act
                        var actual = game.Play(player, opponent);
                        // Assert
                        Assert.AreEqual(expected, actual);
                    }
                }
            }
            
            
        }
        
    }
}
