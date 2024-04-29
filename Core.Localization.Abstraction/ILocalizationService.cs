using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Localization.Abstraction;

public interface ILocalizationService
{
    public ICollection<string>? AcceptLocales { get; set; }

    /// <summary>
    /// Gets the localized string for the given key by <see cref="AcceptLocales"/>.
    /// </summary>
    public Task<string> GetLocalizedAsync(string key, string? keySection = null);

    public Task<string> GetLocalizedAsync(string key, ICollection<string> acceptLocales, string? keySection = null);
}
