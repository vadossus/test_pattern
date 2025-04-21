using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypePattern;

namespace PrototypePatternTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Clone_ShouldCreateCopyWithSameValues()
        {
            // Arrange
            var original = new Person("Alice", 30);

            // Act
            var clone = original.Clone();

            // Assert
            Assert.AreEqual(original.Name, clone.Name);
            Assert.AreEqual(original.Age, clone.Age);
            Assert.AreNotSame(original, clone); 
        }

        [TestMethod]
        public void ModifyingClone_ShouldNotAffectOriginal()
        {
            // Arrange
            var original = new Person("Alice", 30);
            var clone = original.Clone();

            // Act
            clone.Name = "Bob";
            clone.Age = 25;

            // Assert
            Assert.AreEqual("Alice", original.Name);
            Assert.AreEqual(30, original.Age);
        }
    }
}
