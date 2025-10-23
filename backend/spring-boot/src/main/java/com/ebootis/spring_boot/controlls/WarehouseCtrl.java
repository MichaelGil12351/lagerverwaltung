package com.ebootis.spring_boot.controlls;

import com.ebootis.spring_boot.dtos.WareHouseDTO;
import com.ebootis.spring_boot.services.warehouse.WarehouseServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/warehouse")
public class WarehouseCtrl {

    @Autowired
    private WarehouseServiceImpl warehouseService;

    @PostMapping
    public ResponseEntity<WareHouseDTO> createWarehouse(@RequestBody WareHouseDTO dto) {
        WareHouseDTO created = warehouseService.createDTO(dto);
        return new ResponseEntity<>(created, HttpStatus.CREATED);
    }

    @GetMapping("/{id}")
    public ResponseEntity<WareHouseDTO> getWarehouseById(@PathVariable Integer id) {
        return warehouseService.getDTOById(id)
                .map(ResponseEntity::ok)
                .orElseGet(() -> ResponseEntity.notFound().build());
    }

    @GetMapping("/all")
    public ResponseEntity<List<WareHouseDTO>> getAllWarehouses() {
        List<WareHouseDTO> list = warehouseService.getAllDTO();
        if (list.isEmpty()) {
            return ResponseEntity.noContent().build();
        }
        return ResponseEntity.ok(list);
    }
}
