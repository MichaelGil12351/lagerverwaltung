package com.ebootis.spring_boot.controlls;

import com.ebootis.spring_boot.dtos.MovementDTO;
import com.ebootis.spring_boot.services.movement.MovementServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/movement")
public class MovementCtrl {

    @Autowired
    private MovementServiceImpl movementService;

    @PostMapping
    public ResponseEntity<MovementDTO> createMovement(@RequestBody MovementDTO dto) {
        MovementDTO created = movementService.createDTO(dto);
        return new ResponseEntity<>(created, HttpStatus.CREATED);
    }

    @GetMapping("/{id}")
    public ResponseEntity<MovementDTO> getMovementById(@PathVariable Integer id) {
        return movementService.getDTOById(id)
                .map(ResponseEntity::ok)
                .orElseGet(() -> ResponseEntity.notFound().build());
    }

    @GetMapping("/all")
    public ResponseEntity<List<MovementDTO>> getAllMovements() {
        List<MovementDTO> list = movementService.getAllDTO();
        if (list.isEmpty()) {
            return ResponseEntity.noContent().build();
        }
        return ResponseEntity.ok(list);
    }
}
