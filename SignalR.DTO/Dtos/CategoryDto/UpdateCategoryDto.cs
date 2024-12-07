using System;

namespace SignalR.DTO.Dtos.CategoryDto;

public class UpdateCategoryDto
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public bool status { get; set; }
}
