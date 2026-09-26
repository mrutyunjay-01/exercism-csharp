 using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        bool isCapitalise = false;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            // Kebab-case: remove '-' and capitalize the next letter
            if (identifier[i] == '-')
            {
                isCapitalise = true;
            }
            // Omit Greek lowercase letters α through ω
            else if (identifier[i] >= 'α' && identifier[i] <= 'ω')
            {
                continue;
            }
            // Control characters become "CTRL"
            else if (char.IsControl(identifier[i]))
            {
                result.Append("CTRL");
            }
            // Spaces become underscores
            else if (identifier[i] == ' ')
            {
                result.Append('_');
            }
            // Keep letters, capitalizing if required
            else if (char.IsLetter(identifier[i]))
            {
                if (isCapitalise)
                {
                    result.Append(char.ToUpper(identifier[i]));
                    isCapitalise = false;
                }
                else
                {
                    result.Append(identifier[i]);
                }
            }
            // Everything else is omitted
        }

        return result.ToString();
    }
}
