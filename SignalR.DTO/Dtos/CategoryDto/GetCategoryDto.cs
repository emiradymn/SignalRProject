using System;

namespace SignalR.DTO.Dtos.CategoryDto;

public class GetCategoryDto
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public bool status { get; set; }
}
