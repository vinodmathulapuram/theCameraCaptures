namespace TheCameraCaptures.Models;

public sealed record Photo(
    string Title,
    string Category,
    string Location,
    string ImageUrl,
    string AltText);

public static class SamplePhotos
{
    // Replace these sample image URLs with your own files in wwwroot/images.
    public static readonly IReadOnlyList<Photo> All =
    [
        new("Quiet Morning", "Landscapes", "New Jersey", "https://images.unsplash.com/photo-1470770841072-f978cf4d019e?auto=format&fit=crop&w=1400&q=85", "Mountain lake at sunrise"),
        new("City in Motion", "Cityscapes", "New York City", "https://images.unsplash.com/photo-1518391846015-55a9cc003b25?auto=format&fit=crop&w=1400&q=85", "New York City skyline"),
        new("Golden Hour", "Portraits", "New Jersey", "https://images.unsplash.com/photo-1534528741775-53994a69daeb?auto=format&fit=crop&w=1000&q=85", "Portrait of a woman in warm light"),
        new("Open Roads", "Travel", "Pacific Coast", "https://images.unsplash.com/photo-1464822759023-fed622ff2c3b?auto=format&fit=crop&w=1400&q=85", "Mountain range beneath a wide sky"),
        new("After the Rain", "Cityscapes", "Manhattan", "https://images.unsplash.com/photo-1519608487953-e999c86e7455?auto=format&fit=crop&w=1400&q=85", "City skyline at dusk"),
        new("Soft Light", "Portraits", "Studio", "https://images.unsplash.com/photo-1524504388940-b1c1722653e1?auto=format&fit=crop&w=1000&q=85", "Natural-light portrait"),
        new("Into the Blue", "Travel", "Coast", "https://images.unsplash.com/photo-1500375592092-40eb2168fd21?auto=format&fit=crop&w=1400&q=85", "Blue ocean waves"),
        new("Still Earth", "Landscapes", "Mountains", "https://images.unsplash.com/photo-1464278533981-50106e6176b1?auto=format&fit=crop&w=1400&q=85", "Layered mountain landscape"),
        new("City Geometry", "Cityscapes", "New York City", "https://images.unsplash.com/photo-1480714378408-67cf0d13bc1b?auto=format&fit=crop&w=1400&q=85", "Architectural city skyline")
    ];
}
