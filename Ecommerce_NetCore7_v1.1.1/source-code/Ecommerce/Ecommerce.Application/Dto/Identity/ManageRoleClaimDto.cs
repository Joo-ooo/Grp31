﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Dto;

public class ManageRoleClaimDto
{
    [Required]
    public string RoleId { get; set; }
    [Required]
    public string RoleName { get; set; }
    public string Type { get; set; }
    public string Value { get; set; }
    public bool Checked { get; set; }
}
