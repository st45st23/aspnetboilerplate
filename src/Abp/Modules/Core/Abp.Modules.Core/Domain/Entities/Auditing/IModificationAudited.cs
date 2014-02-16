using System;
using Abp.Security.Users;

namespace Abp.Domain.Entities.Auditing
{
    /// <summary>
    /// This interface is implemented by entities which's modification informations (who and when modified) must be stored.
    /// </summary>
    public interface IModificationAudited
    {
        /// <summary>
        /// The last time of modification.
        /// </summary>
        DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Last modifier user for this entity.
        /// </summary>
        AbpUser LastModifierUser { get; set; } //TODO: Think to change this to "int LastModifierUserId"
    }
}