using Microsoft.AspNetCore.Components;

namespace NFLanylizer.Main.Pages;

public partial class Index : ComponentBase
{
    public bool showSelectSeason = false;

    public void SelectSeason()
    {
        showSelectSeason = true;
    }

    public void CancelSelectSeason()
    {
        showSelectSeason = false;
    }
}
