package com.ebootis.spring_boot.dtos;
import lombok.Data;
import lombok.NoArgsConstructor;


@Data
@NoArgsConstructor
public class WareHouseDTO {
    private Integer id;
    private String name;
    private Integer maxCapacity;

}
