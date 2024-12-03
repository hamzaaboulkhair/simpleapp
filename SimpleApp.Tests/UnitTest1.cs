using NUnit.Framework;

namespace SimpleApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Ce code s'exécute avant chaque test (optionnel)
        }

        [Test]
        public void TestAddition()
        {
            // Vérifie si 2 + 2 donne 4
            Assert.That(2 + 2, Is.EqualTo(4), "L'addition est incorrecte");
        }

        [Test]
        public void TestCustomMessage()
        {
            // Vérifie le contenu du message
            string message = "Bienvenue dans SimpleApp";
            Assert.That(message, Is.EqualTo("Bienvenue dans SimpleApp"), "Le message est incorrect");
        }
    }
}
