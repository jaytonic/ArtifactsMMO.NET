namespace ArtifactsMMO.NET.Integration.Tests.Endpoints.MyCharacters
{
    public class CharacterTestFixture : TestFixture
    {
        private string _characterName = "tst-" + new Random().Next(short.MaxValue).ToString();

        public string CharacterName { get { return _characterName; } }
        public void  ForceCharacterName(string characterName)
        {
            _characterName = characterName;
        }
    }
}
