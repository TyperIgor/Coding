namespace TestValidateJson
{
    public class JsonObjectValidate
    {
        [Fact]
        public void JsonObject_ValidateApproveResult_ShouldBePassed()
        {
            // Arrange
            var jsonString = "{\"RunId\":1234,\"testName\":\"LoginTest\",\"Login\":\"user1\",\"status\":\"Passed\",\"durationMs\":1500}";
            // act
            var result = GetJSonFromSTDIN.ParseTheJson(jsonString);

            // assert
            foreach (var item in result)
            {
                Assert.True(item.status == "Passed");
            }
        }
    }
}