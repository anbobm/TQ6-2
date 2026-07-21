public class PasswordValidatorTests
{
    [Fact]
    public void PasswordWithEightCharacters_IsValid()
    {
        Assert.True(new PasswordValidator().IsValid("12345678"));
    }

    [Fact]
    public void PasswordShorterThanEightCharacters_IsInvalid()
    {
        Assert.False(new PasswordValidator().IsValid("1234567"));
    }

    [Fact]
    public void PasswordLongerThanEightCharacters_IsValid()
    {
        Assert.True(new PasswordValidator().IsValid("123456789"));
    }
}