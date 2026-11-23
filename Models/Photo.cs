namespace TheCameraCaptures.Models;

public sealed record Photo(
    string Title,
    string Category,
    string Subcategory,
    string Location,
    string ImageUrl,
    string AltText);

public static class SamplePhotos
{
    // Replace these sample image URLs with your own files in wwwroot/images.
    public static readonly IReadOnlyList<Photo> All =
    [
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/2BBDDC1A-2A5E-4FC6-8CEE-B1035CD69BA0_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/2DE80B34-54A0-4597-8B84-D591911A60EF_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/3CC044D8-1B25-4645-A88D-91BB61DF46DE_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/4A2C8E32-BA06-4AAD-94F3-E827AEB9BA76_4_5005_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/007F5EFE-A5E6-4423-B077-7B49EA22EE6D_4_5005_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/30A7ADB5-05ED-4983-B09B-02951FDD652F_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/526D3555-4E2A-4161-8ADD-7CFA01C77BF8_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/490879C9-5DF9-442A-B97A-FFC1FC35C91A_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/C0766E87-F2C9-4643-90AB-69C1721CEE59_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/CC5DA328-D071-45D5-ADCD-5B9F5A998B1A_4_5005_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/D97BD8A0-EB98-4BF4-BAC8-BEBB84DA77B5_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/F27DAEE6-6A48-49E4-9C92-8CAB2457CE47_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/F67F12B7-8B23-488D-BBB1-7777FF4690E4_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "Babyshoots", "USA", "/Images/Baby/FCB45F53-5114-40B0-B64F-8F5D2A6A85DC_4_5005_c.jpeg", "Pure Smiles"),

        // new("Pure Smiles", "CityScapes", "NewYorkCity", "/Images/CityScapes/00F12900-624D-4213-B0F7-3743930490D3_1_102_a.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/1A128656-278C-4327-B504-75239337A3A3_4_5005_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/1AAF9751-9126-4CA6-8E75-B51F65D15A9D_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/1E6DD273-1D03-4A74-8055-5812AD07B5E4_1_102_a.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/3D799785-F27B-4BE0-8226-270CCD285B0A_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/3DB620E1-1F1A-4C35-B064-45D007F2A916_4_5005_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/8C7C00F4-5A72-4B0D-A775-6058E5D04FF3_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/29A36314-D5B5-4C11-A92F-49469F9FBE96_1_102_o.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/69A55448-9CEA-402D-BDB5-BBF2A4EA6751_4_5005_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/71FDAA36-882D-4535-8E98-55C6AA2F9C75.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/530A6174-CAF0-493D-A5D7-0364C3065F59_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/912F6E55-1F3A-4DF5-A111-5CEE01AD30D7_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/966A039D-DEAE-4307-A0CC-9F37A631E84C_1_102_o.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/3282FADA-A0BA-418D-9D84-77008ECA3B4E_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/78949CFA-779C-4129-9E1E-BF9156944861_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/92393704-9974-4711-9145-27D589EC06CA_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/A9B5F70F-D65F-43F4-969F-2C75F0D69FCD_1_102_a.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/A45B401A-D803-4DAA-8288-40C5A2396A34_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/A156556D-A386-444F-BE94-3D1627C8ED97_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/ABCB2D32-E842-464C-9B78-8610DCB49845_1_102_o.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/B4AE4E58-7CD0-4D4C-95E4-F67FBED7F83D_4_5005_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/B13AAC65-3392-44CA-85A8-BECED0FF405B_1_102_a.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/B67A6CCD-3CB3-4380-B7A1-F0FF4C102EEB_4_5005_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/C1A3C6E0-17CD-4F39-B17F-3963466E2840_4_5005_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/CD0CF72E-B76A-4CDB-B16E-139C804C8656.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/DABA13C4-8A69-4C9C-983B-8CB725BA2B16_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/DF558AA6-6DDD-414A-8DED-6BC04C29B897_1_201_a.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/ED83891F-A435-43B9-8B6A-7B8C63C9806E_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/EF779DF8-C7AE-4438-9F35-88D92833A172_1_105_c.jpeg", "Pure Smiles"),
        // new("Pure Smiles", "CityScapes", "USA", "/Images/CityScapes/F51EC90C-9D42-433F-B06F-8B76A678FD58_1_102_a.jpeg", "Pure Smiles"),


// Events
        new("HemaRamana's Wedding", "Events", "HemaRamana's Wedding", "Kentucky",
            "/Images/Events/HemaRamana/photo1.jpg", "Wedding celebration"),

        new("HemaRamana's Wedding", "Events", "HemaRamana's Wedding", "Kentucky",
            "/Images/Events/HemaRamana/photo2.jpg", "Wedding celebration"),

        new("HemaRamana's Wedding", "Events", "HemaRamana's Wedding", "Kentucky",
            "/Images/Events/HemaRamana/photo3.jpeg", "Wedding celebration"),
new("HemaRamana's Wedding", "Events", "HemaRamana's Wedding", "Kentucky",
            "/Images/Events/HemaRamana/photo4.JPG", "Wedding celebration"),
            // Babyshoots
        new("Pranad's Birthday", "Events", "Pranad's Birthday", "USA",
            "/Images/Baby/Pranad/photo1.jpg", "Pranad's Birthday"),

        new("Pranad's Birthday", "Events", "Pranad's Birthday", "USA",
            "/Images/Baby/Pranad/photo2.jpg", "Pranad's Birthday"),

        new("Pranad's Birthday", "Events", "Pranad's Birthday", "USA",
            "/Images/Baby/Pranad/photo3.jpg", "Pranad's Birthday"),
            
        new("Anjali's ClickS", "Babyshoots", "Anjali's ClickS", "Kentucky",
            "/Images/Baby/Anjali/photo1.jpg", "Baby portrait"),
        
        new("Anjali's ClickS", "Babyshoots", "Anjali's ClickS", "Kentucky",
            "/Images/Baby/Anjali/photo2.jpg", "Baby portrait"),

        new("Anvi's Shoot", "Babyshoots", "Anvi's Shoot", "USA",
            "/Images/Baby/Anvi/photo1.jpg", "Baby portrait"),
        
        new("Anvi's Shoot", "Babyshoots", "Anvi's Shoot", "USA",
            "/Images/Baby/Anvi/photo2.jpg", "Baby portrait"),

        new("Anvi's Shoot", "Babyshoots", "Anvi's Shoot", "USA",
            "/Images/Baby/Anvi/photo3.jpg", "Baby portrait"),

            new("Anvi's Shoot", "Babyshoots", "Anvi's Shoot", "USA",
            "/Images/Baby/Anvi/photo4.jpeg", "Baby portrait"),

            new("Anvi's Shoot", "Babyshoots", "Anvi's Shoot", "USA",
            "/Images/Baby/Anvi/photo5.jpeg", "Baby portrait"),

            new("Tejas", "Portraits", "Tejas", "New Jersey",
            "/Images/Portraits/Tejas/photo1.jpeg", "Tejas portrait")
            // new("Tejas", "Portraits", "Tejas", "New Jersey",
            // "/Images/Portraits/Tejas/photo2.jpg", "Tejas portrait"),
            // new("Tejas", "Portraits", "Tejas", "New Jersey",
            // "/Images/Portraits/Tejas/photo3.jpg", "Tejas portrait"),
            // new("Tejas", "Portraits", "Tejas", "New Jersey",
            // "/Images/Portraits/Tejas/photo4.jpg", "Tejas portrait"),
            // new("Tejas", "Portraits", "Tejas", "New Jersey",
            // "/Images/Portraits/Tejas/photo5.jpg", "Tejas portrait"),
            // new("Tejas", "Portraits", "Tejas", "New Jersey",
            // "/Images/Portraits/Tejas/photo6.jpg", "Tejas portrait")

    ];
}
