using Kata.Prod;
using NUnit.Framework;

namespace Kata
{
    [TestFixture]
    public class GameFeatureTests
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
                        var player = GameInstrument.Scissors;
                        var opponent = GameInstrument.Rock;
                        var game = new RockPaperScissors();
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
                        var player = GameInstrument.Scissors;
                        var opponent = GameInstrument.Paper;
                        var game = new RockPaperScissors();
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
                        var player = GameInstrument.Scissors;
                        var opponent = GameInstrument.Scissors;
                        var game = new RockPaperScissors();
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
                        var player = GameInstrument.Paper;
                        var opponent = GameInstrument.Scissors;
                        var game = new RockPaperScissors();
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
                        var player = GameInstrument.Paper;
                        var opponent = GameInstrument.Rock;
                        var game = new RockPaperScissors();
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
                        var player = GameInstrument.Scissors;
                        var opponent = GameInstrument.Scissors;
                        var game = new RockPaperScissors();
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
                        var player = GameInstrument.Rock;
                        var opponent = GameInstrument.Paper;
                        var game = new RockPaperScissors();
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
                        var player = GameInstrument.Rock;
                        var opponent = GameInstrument.Scissors;
                        var game = new RockPaperScissors();
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
                        var player = GameInstrument.Rock;
                        var opponent = GameInstrument.Rock;
                        var game = new RockPaperScissors();
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
