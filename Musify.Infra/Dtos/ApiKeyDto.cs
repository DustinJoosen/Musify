using Musify.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify.Infra.Dtos;

public record ApiKeyDto (
    string Key, 
    int? UserId, 
    ApiKeyPermissions Permissions,
    DateTime? ExpirationDate, 
    DateTime? CreatedAt);